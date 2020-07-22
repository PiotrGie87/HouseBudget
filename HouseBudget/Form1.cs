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
    public partial class Form1 : Form
    {
        //kontener List przechowujący obiekty typu "Cost"
        List<Cost> costsList = new List<Cost>();

        public Form1()
        {
            InitializeComponent();
            


        }

        
        
        
        

        //Metoda AddCost() będzie pobierała dane na temat wydatku 
        private void AddCost(Cost cost)
        {
            //tymczasowa zmienna typu decimal przechowująca wartość ceny wydatku domowego
            decimal price;
            //poberanie nazwy wydatku domowego
            cost.Name = tbCost.Text;

            //pobieranie ceny
            if (decimal.TryParse(tbAmount.Text, out price))
            {
                cost.Amount = price;
            }
            else
            {
                MessageBox.Show("Podaj poprawną cenę");
                tbAmount.Text = "";

                //przy obsłudze buttona przekazującego nowy wydatek do kolekcji powinniśmy wpisać warunek. Działamy tylko wtedy gdy własciwości name i Amount nie są puste
            }
            

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

         

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Utworzenie obiektu typu Cost

            Cost myCost = new Cost();

            //pobranie danych o wydatku

            AddCost(myCost);

            // Dodawanie OBIEKTÓW TYPU COST do Listy

            costsList.Add(myCost);

            //Numerowanie nowego wydatku 

            int iNumber;

            iNumber = costsList.Count;

            myCost.SetId = iNumber; // ustawianie id obiektu klasy Cost, które będzie zgodne z tym co wyświetla się na ListBoxie

            lblAllCosts.Text = iNumber.ToString();

           
            //wyświetlenie danych w listboxie (NIE ZAPOMMIEĆ O WPROWADZENIU FORMATOWANIA)

            lbCosts.Items.Add(iNumber + ". " + myCost.Name + "" + myCost.Amount);


           
            // FORMATOWANIE LIST BOXA

            //................... wyczyszczenie text boxów
            tbAmount.Clear();
            tbCost.Clear();
            
        }

        //Metoda wyświetlająca aktualny stan Salda
        private void ShowBalance(MyAccount balance)
        {
            lblBalanceValue.Text = balance.Balance.ToString("c");
        }

        private void mojeKontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Account account = new Account();
            
            if(account.ShowDialog() == DialogResult.OK) //to co jest w nawiasie normalnie się wykonuje tj. pierwsza część warunku normalnie wywołuje okno. 
            {
                MyAccount account1 = new MyAccount();
                ShowBalance(account1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //DOKOŃCZYC USUWNIE!!!
        {
            int i;

            i = lbCosts.SelectedIndex;
            lbCosts.Items.RemoveAt(i);

            //DODAC USUWANIE WSKAZANEGO WYDATKU TAKŻE Z LISTY OBIEKTÓW TYPU COST!!!
        }

        private void mojeWydatkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wyświetlenie okna Moje Wydatki

            MyCosts form = new MyCosts();
            form.ShowDialog();
            
        }
    }
}
