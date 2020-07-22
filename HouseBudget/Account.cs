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
    public partial class Account : Form
    {
        private decimal _acc; // pole do przehowywania wartości salda nowo tworzonego konta 
        public Account()
        {
            InitializeComponent();
            this._acc = _acc;  
        }

        
        public decimal Acc //właściwość zwracająca wartość środków początkowych na koncie
        {
            get { return _acc; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            _acc = Convert.ToDecimal(tbCash.Text); //przypisanie polu wpisanej przez użytkownika wartości konta
            MyAccount konto = new MyAccount(); //nowy obiekt MyAccount
            konto.Balance = _acc; //przypisanie poprzez właściwosć Balance wartości wpisanej przez użytkownika
            lblSaldo.Text = konto.Balance.ToString("c"); // wyświetlenie tej wartości w labelce
            tbCash.Text = ""; // wyczyszczenie textboxa

            

        }

        
        

        private void Account_Load(object sender, EventArgs e)
        {
            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          
        }

        //Po kliknięciu przycisku pojawi się forma kalkulator w kontrolce panel
        private void btnCalc_Click(object sender, EventArgs e)
        {
            Kalkulator kalkulator = new Kalkulator() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panCalc.Controls.Add(kalkulator);
            kalkulator.Show();
        }
    }
}
