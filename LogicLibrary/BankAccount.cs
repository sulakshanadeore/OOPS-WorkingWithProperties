using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class BankAccount
    {

        public BankAccount()
        {
            Console.WriteLine("Bank Account Object created");
        }
        //Automatically(Auto) implemented property-used for only accepting and diplaying(no logic/no validation etc)
        public int AccountNo { get; set; }
        public string CustomerName { get; set; }

        public DateTime OpeningDate { get; set; }

        public string City { get; set; }

        public double Balance { get; protected set; }

      

         protected string _pwd;
        public string Password 
        {
            private get 
            {
                return _pwd; 
            } 
            set {

                string hashedpwd = "xyz" + value.GetHashCode();
                _pwd = hashedpwd;
            
            
            } 
        }


        //public string PrintPwd()
        //{
        //    return _pwd;
        //}

    }


    public class SavingAccount : BankAccount
    {

        public SavingAccount()
        {
            Console.WriteLine("Savings Account Object created");
        }

        public void Deposit(double depositAmt)
        {
            Console.WriteLine("Enter your password");
            string p = Console.ReadLine();
            string acceptedPwd = "xyz" + p.GetHashCode();
            if (acceptedPwd == _pwd)
            {
                base.Balance =base.Balance + depositAmt;
                Console.WriteLine($"Current Balance={Balance:C}");
            }
            else
            {
                Console.WriteLine("U are not allowed to deposit");
            }
        }


    }
}
