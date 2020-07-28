using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private string _tag;
        private string _theData;
        private string _tag2;
        

        //konstruktor

        public Cost()
        {
            this._name = _name;
            this._amount = _amount;
            this._id = _id;
            this._payed = _payed;
            this._tag2 = _tag2;
            this._theData = _theData;

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
            set { _payed = value;}
        }

        // własciwość zwracająca lub ustawiająca tag (jedzenie, media, raty, mieszkanie, samochód, przyjemności, edukacja, inne)
        
        public string TheTag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        //właściwość zwracająca datę

        public string TheData
        {
            get { return _theData; }
            set { _theData = value;}
        }

        //właściwość zwracająca drugi tag (opłata stała lub nieregularna)

        public string SecondTag
        {

            get { return _tag2; }
            set { _tag2 = value; }


        }

    }
}
