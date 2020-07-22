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
    public partial class Kalkulator : Form
    {

        double arg1 = 0;  //zmienna argument 1
        double arg2 = 0;  // zmienna argument 2
        char oper;    // operator
        double result = 0;   // wynik dziłania

        public Kalkulator()
        {
            InitializeComponent();
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.result = result;

        }

        private void butClick(object sender, EventArgs e) // metoda wyświetlająca dowolną liczbę na textbox
        {
            if (table1.Text == "0")
            {
                table1.Text = "";
            }

            string l3 = table3.Text;
            if (l3.Contains("="))
            {
                table3.Text = "";
                table2.Text = "";
            }


            Button every = new Button();
            every = (Button)sender;
            table1.Text += every.Text;
            table3.Text += every.Text;


        }

        private void operClick(object sender, EventArgs e) // metoda obsługująca przyciski dodawania, odejmowania, mnożenia i dzilenia
        {
            Button op = new Button();
            op = (Button)sender;
            table3.Text += op.Text;

            if (arg1 == 0)
            {
                arg1 = Double.Parse(table1.Text); // To co wpisaliśmy w textbox staje się naszym argumentem1

            }
            else
            {
                if (table1.Text != "")
                {
                    arg2 = Double.Parse(table1.Text); // Jeżeli argument 1 został już okreslony, z wpisanej wartości w textbox pobieramy argument2
                }
                else
                {

                }

            }

            string lastIn = table2.Text;

            if (lastIn.EndsWith(op.Text) || (lastIn == "")) //wykonywane jeżeli kontynuujemy cały czas tę samą operację np. raz za razem dodajemy do siebie poszczególne liczby
                                                            //lub jest to pierwsze działanie
            {

                switch (op.Text) // w zalezności od tego jaki przycisk naciśniemy zostaje wykonana inna operacja. 
                                 //Operacja wykonywana jest nawet wtedy gdy nie mamy jeszcze argumentu2. 
                                 //W przypadku + i _ przyjmuje on wartość 0, a w przypadku * i / przyjmuje wartość 1.
                                 //Wynik wykonaniu działania, argument1 automatycznie przyjmuje wartośc wyniku. Dzięki temu istnieje możliwość zachowania ciągłości operacji.
                                 //tj. ponowienia poprzedniego działania np. kilka dodawań pod rząd lub kilka odejmowań pod rząd.
                {
                    case "+":
                        result = arg1 + arg2;
                        arg1 = result;
                        arg2 = 0;
                        table2.Text = Convert.ToString(result) + op.Text;
                        table1.Text = "";
                        break;

                    case "-":
                        result = arg1 - arg2;
                        arg1 = result;
                        arg2 = 0;
                        table2.Text = Convert.ToString(result) + op.Text;
                        table1.Text = "";
                        break;

                    case "*":
                        if (arg2 == 0)
                        {
                            arg2 = 1;
                        }
                        result = arg1 * arg2;
                        arg1 = result;
                        arg2 = 0;
                        table2.Text = Convert.ToString(result) + op.Text;
                        table1.Text = "";
                        break;

                    case "/":
                        if (arg2 == 0)
                        {
                            arg2 = 1;
                        }
                        result = arg1 / arg2;
                        arg1 = result;
                        arg2 = 0;
                        table2.Text = Convert.ToString(result) + op.Text;
                        table1.Text = "";
                        break;




                }


            }
            else // wykonywane jeżeli w ciągu działań zmienimy znak działania. Np. po dwóch dodawaniach będziemy chcieli pomnożyć to przez 2 tj. (5+2+3*2).
            {
                if (lastIn.EndsWith("+"))
                {
                    result = arg1 + arg2;
                    arg1 = result;
                    arg2 = 0;
                    table2.Text = Convert.ToString(result) + op.Text;
                    table1.Text = "";
                }
                if (lastIn.EndsWith("-"))
                {
                    result = arg1 - arg2;
                    arg1 = result;
                    arg2 = 0;
                    table2.Text = Convert.ToString(result) + op.Text;
                    table1.Text = "";
                }
                if (lastIn.EndsWith("*"))
                {
                    if (arg2 == 0)
                    {
                        arg2 = 1;
                    }
                    result = arg1 * arg2;
                    arg1 = result;
                    arg2 = 0;
                    table2.Text = Convert.ToString(result) + op.Text;
                    table1.Text = "";
                }
                if (lastIn.EndsWith("/"))
                {
                    if (arg2 == 0)
                    {
                        arg2 = 1;
                    }
                    result = arg1 / arg2;
                    arg1 = result;
                    arg2 = 0;
                    table2.Text = Convert.ToString(result) + op.Text;
                    table1.Text = "";
                }
            }





        }

        private void butEq_Click(object sender, EventArgs e) // To wydarzy się po naciśnięciu =. 
                                                             //Ważne: po wpisaniu drugiego argumentu w tekstbox1 nie staje się on automatycznie arg2. 
                                                             //Ta metoda będzie więc musiała arg2 określić...
        {
            string act = table2.Text; //zmienna o wartości textboxa2. Dzięki temu będziemy mogli zastosować metodę Contains i znaleźć w nim odpowidni znak dziłania
            Button row = new Button();
            row = (Button)sender;
            table3.Text += row.Text;


            if (act.Contains("+"))
            {
                arg2 = Double.Parse(table1.Text); //tworzymy drugi argument z wpisanej przez użytkownika wartości
                result = arg1 + arg2;
                table1.Text = "0"; //wracamy do pierwotnego wyjściowego ustawienia klakulatora
                arg1 = 0;
                arg2 = 0;
                table2.Text = Convert.ToString(result); //wyświetlenie wyniku
            }

            if (act.Contains("-"))
            {
                arg2 = Double.Parse(table1.Text); //tworzymy drugi argument z wpisanej przez użytkownika wartości
                result = arg1 - arg2;
                table1.Text = "0"; //wracamy do pierwotnego wyjściowego ustawienia klakulatora
                arg1 = 0;
                arg2 = 0;
                table2.Text = Convert.ToString(result);
            }
            if (act.Contains("/"))
            {
                arg2 = Double.Parse(table1.Text); //tworzymy drugi argument z wpisanej przez użytkownika wartości
                result = arg1 / arg2;
                table1.Text = "0"; //wracamy do pierwotnego wyjściowego ustawienia klakulatora
                arg1 = 0;
                arg2 = 0;
                table2.Text = Convert.ToString(result); //wyświetlenie wyniku
            }

            if (act.Contains("*"))
            {
                arg2 = Double.Parse(table1.Text); //tworzymy drugi argument z wpisanej przez użytkownika wartości
                result = arg1 * arg2;
                table1.Text = "0"; //wracamy do pierwotnego wyjściowego ustawienia klakulatora
                arg1 = 0;
                arg2 = 0;
                table2.Text = Convert.ToString(result);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            table1.Text = "0";
            table2.Text = "";
            table3.Text = "";
            arg1 = 0;
            arg2 = 0;
            result = 0;
        }


        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }
    }
}
