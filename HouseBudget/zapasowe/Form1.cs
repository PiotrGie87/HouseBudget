using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HouseBudget
{
    public partial class Form1 : Form
    {
        //kontener List przechowujący obiekty typu "Cost"
        public List<Cost> costsList = new List<Cost>();
        MyCost form2;
        Account account;
        MyAccount account1;
        string listDetails = "{0,-10}{1,-50}{2,-30}";

        public Form1()
        {
            

            InitializeComponent();
            form2 = new MyCost();
            account = new Account();
            account1 = new MyAccount();

             

        }

        private void CopyCostList(List<Cost> newCostList) // metoda kopiująca listę kosztów do drugiej listy kosztów
        {
            Cost cost = new Cost();
            for (int i = 0; i < costsList.Count; i++)
            {
                cost = costsList[i];
                newCostList.Add(cost);
            }
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

            //pobieranie tagu

            cost.TheTag = cbTag.SelectedItem.ToString();

            //pobieranie daty

            cost.TheData = dateTimePicker.Value.ToString();

            //ustawianie tag 2 czyli statusy wydatek stały/wydatek niecykliczny
            if(cbEveryMonth.Checked == false)
            {
                cost.SecondTag = "Niecykliczny";
            }
            else
            {
                cost.SecondTag = "Wydatek stały";
            }

            cost.IsPayed = "NIE"; // domyślnie nowy obiekt typu Cost tworzony jest ze statusem nieopłacony
            

            

        }

        public decimal HighestCost() // wyszykiwanie największego wydatku
        {
            decimal highest = 0; // pole do przechowywania wartości największego wydatku
            
            decimal costsAmount = 0; // pojedynczy koszt wydatku
            

            for (int i = 0; i < costsList.Count; i++)
            {
                costsAmount = costsList[i].Amount;

                if(costsAmount > highest)
                {
                    highest = costsAmount;
                }

            }        
            
            return highest;
        }

        public decimal LowerCost() // wyszukiwanie wydatku o najmniejszej wartości
        {
            decimal lowest = costsList[0].Amount;
            decimal costAmount = 0;

            for (int i = 0; i < costsList.Count; i++)
            {
                costAmount = costsList[i].Amount;

                if(costAmount <= lowest)
                {
                    lowest = costAmount;
                }
            }
            return lowest;

        }

        public decimal AverageCost()
        {
            decimal average = 0;
            int numberOfCosts = costsList.Count; // ilość wszystkich wydatków
            decimal everyCost = 0; // pole przechowujące wartosc wszystkich wydatków
            decimal oneCost = 0;

            for (int i = 0; i < costsList.Count; i++)
            {
                oneCost = costsList[i].Amount;
                everyCost += oneCost;
            }

            average = everyCost / numberOfCosts; // łączna kwotra kosztów przez ich ilość daje nam średnią :)




            return average;
        }


        private decimal[] MoneyToTable() // metoda tworzoca tabelę jednowymiarową z wartości kwotowych obiektów typu Cost i zwracająca tabelę
        {
            int numberOfCosts = 0; // pole do przechowywania ilości wydatków w liście wydatków typu Cost
            numberOfCosts = costsList.Count;
            decimal costAmount = 0;
            decimal[] costsValues = new decimal[numberOfCosts]; // tabela o wielkości odpowiadającej ilości kosztów

            for (int i = 0; i < costsList.Count; i++) // iteracja po kolekcji obiektów typu Cost i dodawanie ich do tablicy
            {
                costAmount = costsList[i].Amount;
                costsValues[i] = costAmount;
            }

            return costsValues;
        }


        private void SetNumberOfCosts() //metoda ustawiająca ilość całkowitą kosztów w labelu 
        {
            int it;
            it = costsList.Count;
            lblAllCosts.Text = it.ToString();
        }

        private void PassCost(Cost cost) //metoda przekazująca koszt do kontrolki ListView, numerująca wydatek i tworząca zapis w list boxie
        {
            //Numerowanie nowego wydatku 

            int iNumber;

            iNumber = costsList.Count; // długośc listy obiektów typu Cost

            cost.SetId = iNumber; // ustawianie id obiektu klasy Cost, które będzie zgodne z tym co wyświetla się na ListBoxie

            SetNumberOfCosts();

            //przekazywanie id kosztu do kontrolki ListView formie MyCost
            ListViewItem it = new ListViewItem(iNumber.ToString());

            //przekazywanie nazwy wydatku do ListView
            it.SubItems.Add(cost.Name);

            //przekazywanie kwoty wydatku do ListView
            it.SubItems.Add(cost.Amount.ToString("c"));

            //przekazywanie taga
            it.SubItems.Add(cost.TheTag);

            //przekazywanie daty

            it.SubItems.Add(cost.TheData);

            if(cost.IsPayed == "TAK")
            {
                it.SubItems.Add("TAK");
            }
            else
            {
                it.SubItems.Add("NIE");
            }

            //przekazywanie listViewItem do listView

            form2.lvCosts.Items.Add(it);

            //DODAWANIE ZAPISU DO LIST BOXA

            if (cost.IsPayed == "NIE")
            {
                lbCosts.Items.Add(String.Format(listDetails, iNumber, cost.Name, cost.Amount.ToString("c")));     //iNumber + ". " + cost.Name + "" + cost.Amount.ToString("c")); // ZADBAC O ODPOWIEDNIE FORMATOWANIE
            }
            else if(cost.IsPayed == "TAK")
            {
                lbPayedCost.Items.Add(String.Format(listDetails, iNumber, cost.Name, cost.Amount.ToString("c"))); // w zalezności czy jest oplacony czy nie wpada do innego list boxa
            }

            
                

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //lbCosts.Items.Add(String.Format(listDetails, "ID", "Nazwa", "Koszt"));
            lblLbCosts.Text = String.Format(listDetails, "ID", "Nazwa", "Koszt");
            lblLbPayedCosts.Text = String.Format(listDetails, "ID", "Nazwa", "Koszt");




        }

         

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Utworzenie obiektu typu Cost

            Cost myCost = new Cost();

            //pobranie danych o wydatku

            AddCost(myCost);

            // Dodawanie OBIEKTÓW TYPU COST do Listy

            costsList.Add(myCost);

            // przekazywanie wydatku do ListView w formie MyCost

            PassCost(myCost);

            

            

           
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
            
            
            if(account.ShowDialog() == DialogResult.OK) //to co jest w nawiasie normalnie się wykonuje tj. pierwsza część warunku normalnie wywołuje okno.
                                                        //Jeżeli utworzymy konto zasilając je gotówką, to opcja utworzenia konta staje się nieaktywna
            {
                
                ShowBalance(account1);
                toolStripMenuItem1.Enabled = false;
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e) //DOKOŃCZYC USUWNIE!!!
        {
            if(lbCosts.SelectedItem != null)
            {
                int i;

                i = lbCosts.SelectedIndex;
                lbCosts.Items.RemoveAt(i);

                costsList.RemoveAt(i); // usuwanie obiektu z listy obiektów typu Cost

                SetNumberOfCosts(); //ustawienie całkowitej liczby wydatków

                
            }
            else
            {
                MessageBox.Show("Zaznacz nieopłacony wydatek");
            }


        }

        private void mojeWydatkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wyświetlenie okna Moje Wydatki

            
            form2.ShowDialog();
            


        }

        private void showC_Click(object sender, EventArgs e)
        {
            if(panDetails.Visible == false)
            {
                panDetails.Visible = true;
            }
            else
            {
                panDetails.Visible = false;
            }
                

            
        }

        private void btnPay_Click(object sender, EventArgs e) //przenoszenie wydatków z list boxa do zapłacenia do list boxa zapłacone
        {
            if(lbCosts.SelectedIndex != -1)
            {
                int indeks; // pole przechowujące indeks wydatku w list boxie i liście obiektów typu Cost
                decimal amount; // pole przechowujące wartość wydatku z listy obiektów typu Cost
                decimal saldo; // pole przechowujace aktualną wartośc salda
                

                foreach (int item in lbCosts.SelectedIndices) // dodawanie zaznaczonych wydatków do listboxa zapłacone
                {
                    
                    indeks = item;

                    lbPayedCost.Items.Add(lbCosts.Items[indeks].ToString());
                    

                    amount = costsList[indeks].Amount; // wartość zaznaczonego wydatku pobrana z listy obiektów typu Cost
                    costsList[indeks].IsPayed = "TAK"; // przeniesiony do listboxa payedCosts koszt zostaje oznaczony jako opłacony



                    saldo = account1.Balance;
                    account1.Balance = saldo - amount; // odjęcie od salda wartości zaznaczonego wydatku

                    ShowBalance(account1); // wyświetlenie końcowej wartości salda (po odjęciu wydatku)


                }

                
            }

            while (lbCosts.SelectedItem != null)
            {
                lbCosts.Items.Remove(lbCosts.SelectedItem.ToString());
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zapis musi dotyczyć wszystkich danych z listy obiektów typu Cost, początkowej wartości salda, wartości salda po dokonanych opłatach

            

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK && account1.Balance != 0 && costsList != null) 
            {
                string fName = saveFileDialog1.FileName;
                FileMode mode;


                

                if(File.Exists(fName) == false)
                {
                    mode = FileMode.CreateNew;
                }
                else
                {
                    mode = FileMode.Create; //nie mam pewności czy opcja create jest prawidłowa w momencie gdy plik już istnieje
                }

                try
                {
                    FileStream stream = new FileStream(fName, mode);
                    StreamWriter data = new StreamWriter(stream);

                    int id;
                    string name;
                    decimal amount;
                    string payed;
                    string saveCostLine;
                    string tag;
                    string tag2;
                    string date;
                    
                    string mybalance = String.Format("<{0}<",account1.Balance.ToString());

                   

                    for (int i = 0; i < costsList.Count; i++)
                    {
                        id = costsList[i].SetId;
                        name = costsList[i].Name;
                        amount = costsList[i].Amount;
                        payed = costsList[i].IsPayed;
                        tag = costsList[i].TheTag;
                        tag2 = costsList[i].SecondTag;
                        date = costsList[i].TheData;
                        saveCostLine = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", id, name, amount, payed,tag,tag2,date); // forma w jakiej będzie zapisany tekst w save file

                        data.WriteLine(saveCostLine);
                         
                    }

                    data.WriteLine(mybalance); // zapis informacji o stanie konta (saldzie)





                    data.Close();
                    stream.Close();
                }
                catch(IOException exception)
                {
                    MessageBox.Show("Wystąpił błąd: " + exception.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Zanim zapiszesz sesję utwórz konto i dodaj do niego środki", "Brak środków na koncie!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Cost SplitThis(string file) //metoda dzieląca stringa i tworząca nowy obiekt typu Cost. wykorzystywana do obróbki danych z pliku tekstowego w metodzie LOAD
        {
            string[] fileArray = file.Split('|'); // dzielenie stringa z linijką tekstu z załadowanego pliku i pakowanie do do tabeli
            int id = Convert.ToInt32(fileArray[0]); //zmienna przechowująca 1 fragment tekstu będący id
            string name = fileArray[1]; // analogicznie nazwa
            decimal amount = Convert.ToDecimal(fileArray[2]); //analogicznie koszt
            string payed = fileArray[3]; // analogicznie info o tym czy jest zapłacone
            string tag = fileArray[4]; //info o rodzaju płatności
            string tag2 = fileArray[5]; // info o tagu 2 czy płatnośc cykliczna
            string date = fileArray[6]; // zapisana data
            Cost cost = new Cost();
            cost.SetId = id;
            cost.Name = name;
            cost.Amount = amount;
            cost.IsPayed = payed;
            cost.TheTag = tag;
            cost.SecondTag = tag2;
            cost.TheData = date;
            return cost;
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; 
            result = openFileDialog1.ShowDialog(); //otwiera okno wczytania pliku

            if (result == DialogResult.OK) // wczytanie pliku tylko wtedy gdy użytkownik liknie ok
            {
                string name = openFileDialog1.FileName; // zmienna będąca nazwa wybranego pliku
                string oneLine; //jedna linia wczytanego tekstu z pliku .txt
                

                try
                {
                    StreamReader data = new StreamReader(name); 

                    while(data.EndOfStream == false) //pętla wykonuje się aż nie dojdziemy do końca pliku
                    {
                        oneLine = data.ReadLine();

                        //teraz trzeba się zajać podzieleniem stringa i wpakowaniem poszczególnych elementów w tablicę

                        if (oneLine.Contains("|"))
                        {
                            Cost cost = new Cost();
                            cost = SplitThis(oneLine); //dzielenie stringa i tworzenie obiektu typu Cost
                            costsList.Add(cost); // dodawanie kosztu do listy kosztów
                            PassCost(cost); // przekazywanie kosztu do listy wydatków
                        } 
                        else if (oneLine.Contains("<")) //pobieranie wielkości salda
                        {
                            string[] balance = oneLine.Split('<');
                            
                            account1.Balance = Convert.ToDecimal(balance[1]); // ustalanie wysokości salda
                            ShowBalance(account1); // wyświetlanie wysokości salda

                            //po załadowaniu danych dodających do konta środki, opcja utworzenia konta zostaje usunięta

                            if (account1.Balance != 0)
                            {
                                toolStripMenuItem1.Enabled = false;
                            }
                        }

                        

                        

                    }

                }
                catch(IOException exception)
                {
                    MessageBox.Show("Wystąpił błąd" + exception.Message,"bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void diagramyToolStripMenuItem_Click(object sender, EventArgs e) //otwarcie okna z diagramami
        {
            Diagrams diagram = new Diagrams();

            LoadTags(diagram, cbTag); // zebranie informacji z listy obiektów typu Cost do wypełnienia combobox tag
            CopyCostList(diagram.copyCostList); // skopiowanie obiektów Listy obiektów typu Cost


            diagram.ShowDialog();
            

        }

        private void LoadTags(Diagrams diagram,ComboBox combo) // zebranie informacji z listy obiektów typu Cost do wypełnienia combobox tag
        {
            string tag; // pole przechowujący wartość pojedynczego taga

            for (int i = 0; i < costsList.Count; i++)
            {
                tag = costsList[i].TheTag.ToString();

                if (!(diagram.cbTag.Items.Contains(tag))) // warunek zabezpieczający przed dublowaniem tagów
                {
                    diagram.cbTag.Items.Add(tag);
                }
                
            }

            
        }

        

        

        private void btnkontrolny_Click(object sender, EventArgs e)
        {
            decimal liczba;
            liczba = HighestCost();

            MessageBox.Show(liczba.ToString());
        }
    }
}
