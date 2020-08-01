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
        public List<Cost> copyCostList = new List<Cost>();
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


            chart.Series.RemoveAt(0); //czyszczenie obecej serii //SPRAWIA PROBLEM PRZY USUWANIU PRZYCISKIEM USUŃ
            chart.Series.Add(tag); // dodawanie serii zgodnej z wybranym tagiem
            chart.Series[tag].Points.Clear(); // czyszczenie punktów na charcie




            for (int i = 0; i < copyCostList.Count; i++) 
            {
                
                if(copyCostList[i].TheTag == tag) 
                {
                    chart.Series[tag].Points.AddXY(copyCostList[i].Name, copyCostList[i].Amount.ToString());
                }
                

            }


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
            else if(cbTag.SelectedItem != null && cbAnotherData.SelectedItem == "Budżet") // OGARNĄĆ DLACZEGO BUDŻET POJAWIA SIĘ JAKO DRUGI
            {
                decimal budget;
                budget = openBalance;
                string nameOfTheBudget = cbAnotherData.SelectedItem.ToString();
                SetChart();
                chart.Series.Add(nameOfTheBudget);
                chart.Series[nameOfTheBudget].Points.AddXY("Budżet", budget);

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
            cbTag.SelectedText = null; // wciąz się znajdują na widoku
            cbAnotherData.SelectedText = null; // wciąż się znajdują na widoku  //DO POPRAWY
            btnLoadChart.Enabled = true;
        }
    }
}
