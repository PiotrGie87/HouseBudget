using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBudget
{
    class MyAccount
    {
        //statyczne pole salda
        private static decimal balance = 0;

        //konstruktor przyjmujący poczatkową wartość salda - na razie go nie ma

        

        // właściwość tylko do odczytu zwracająca aktualną wartość salda

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //metoda dodajaca środki do salda

        public void Deposit (decimal cash)
        {
            balance += cash;
        }

        //metoda zdejmująca środki z Salda

        public void Withdraw(decimal cash)
        {
            balance -= cash;
        }

        




    }
}
