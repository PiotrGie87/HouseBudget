using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBudget
{
    public class Cost //klasa pojedynczego wydatku np opłata za mieszkanie, zawierający jego nazwę i koszt oraz info o ttym czy jest opłacpone
    {
        //pola 
        private string _name;
        private decimal _amount;
        private int _id;
        private string _payed;
        

        //konstruktor

        public Cost()
        {
            this._name = _name;
            this._amount = _amount;
            this._id = _id;
            this._payed = _payed;
        }

        //właściwości

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public int SetId
        {
            get { return _id; }
            set { _id = value;}
        }
        // właściwość zwracająca lub ustawiająca informację czy dany wydatek został już opłacony

        public string IsPayed
        {
            get { return _payed; }
            set { _payed = value; }
        }

        //metoda przekazująca dne do listView

        public void GetTheList(List<Cost> theList)
        {
            
        }

    }
}
