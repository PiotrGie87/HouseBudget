using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseBudget
{
    public partial class Diagrams : Form
    {
        public List<Cost> copyCostList = new List<Cost>(); // kopia listy obiektów typu Cost zapełniająca się wraz z otwarciem niniejszej formy. 
                                                           //Odpowiednia  metoda znajduje się w Form1
        public decimal openBalance;
        
        public Diagrams()
        {
            InitializeComponent();
            this.copyCostList = copyCostList;
        }

        


        private void Diagrams_Load(object sender, EventArgs e)
        {
            
        }
        private void SetChart() // ładowanie do tabeli zestawienia kosztów o wybranym tagu z ich wartością cenową
        {
            
            string tag; //pole przechowujące pojedynczego taga

            tag = cbTag.SelectedItem.ToString(); // tag równy wybranemu przez nas w comboboxie elementowi


           
            chart.Series.Add(tag); // dodawanie serii zgodnej z wybranym tagiem
            //chart.Series[tag].Points.Clear(); // czyszczenie punktów na charcie WYKORZYSTAĆ PRZY CZYSZCZENIU TABELI




            for (int i = 0; i < copyCostList.Count; i++) 
            {
                
                if(copyCostList[i].TheTag == tag) 
                {
                    chart.Series[tag].Points.AddXY(copyCostList[i].Name, copyCostList[i].Amount.ToString());
                }
                

            }


        }



        private decimal WholeTagCost(string tag) //. metoda porównująca łączna wartość wydaną na wydatki z danego taga
        {
            decimal wholeTagCost = 0;
            decimal oneCost;

            for (int i = 0; i < copyCostList.Count; i++)
            {
                if(copyCostList[i].TheTag == tag)
                {
                    oneCost = copyCostList[i].Amount;
                    wholeTagCost += oneCost;
                }
                

                
            }
            return wholeTagCost;
            

        }

        private void SetTwoElChart() // metoda porówbnująca wysokość kosztów całego taga z początkowym budżetem
        {
            string tag = cbTag.Text;
            decimal wholeTagCost = WholeTagCost(tag);
            decimal budget = openBalance;
            string nameOfTheBudget = String.Format("{0} {1}", cbAnotherData.SelectedItem.ToString(), openBalance);

            tag = String.Format("{0} {1}", cbTag.Text, wholeTagCost);


            

            chart.Series.Add(tag);
            chart.Series[tag].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; 

            chart.Series[tag].Points.AddXY(tag, wholeTagCost);
            chart.Series[tag].Points.AddXY(nameOfTheBudget, budget);
            
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button = (Button)sender;
            button.Enabled = false;

            if (cbTag.SelectedItem != null && cbAnotherData.SelectedItem == "Koszt")
            {
                SetChart();
            }
            else if(cbTag.SelectedItem != null && cbAnotherData.SelectedItem == "Budżet") 
            {
                SetTwoElChart();
                

            }
            else
            {
                MessageBox.Show("Wskaż dane do diagramu!");
                button.Enabled = true;
            }
            
        }

        private void btnChartClear_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            //cbTag.SelectedText = ""; // wciąz się znajdują na widoku
            //cbAnotherData.SelectedText = ""; // wciąż się znajdują na widoku  //DO POPRAWY
            btnLoadChart.Enabled = true;
        }
    }
}
