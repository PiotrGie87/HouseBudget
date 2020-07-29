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
        public Diagrams()
        {
            InitializeComponent();
            this.copyCostList = copyCostList;
        }

        


        private void Diagrams_Load(object sender, EventArgs e)
        {
            
        }
        public void SetChart() // całkowicie do przemyślenia
        {
            
            string tag; //pole przechowujące pojedynczego taga

            tag = cbTag.SelectedItem.ToString(); // tag równy wybranemu przez nas w comboboxie elementowi


            chart.Series.RemoveAt(0); //czyszczenie obecej serii
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
            SetChart();
        }
    }
}
