using LogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();
            account.AccountNo = 123;
            account.CustomerName = "Jack";
            account.City = "Banglaore";
            account.Password = "Jack@123";
            
            Console.WriteLine(account.AccountNo);
            Console.WriteLine(account.CustomerName);
            Console.WriteLine(account.City);
            Console.WriteLine($"Initial Balance={account.Balance:C}");
            account.Deposit(10000);
            account.Deposit(20000);
           // Console.WriteLine(account.PrintPwd());
           


            //Customers c = new Customers();
            //c.CustomerID = 1;
            //c.CustomerName = "James";
            //c.Pin = 123;


            //Customers c = new Customers(1, "James", "Mumbai");

            //Console.WriteLine(c.CustomerID);
            //Console.WriteLine(c.CustomerName);
            //Console.WriteLine("did u forgot your pin");
            //c.ForgotPin=Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine(c.City);
            // Console.WriteLine(c.Pin);


            //Person p=new Person();

            //Console.WriteLine("enter Name");
            //p.PersonName = Console.ReadLine();
            //Console.WriteLine($"You entered {p.PersonName}");

            //Console.WriteLine("Enter age");
            //p.Age=Convert.ToInt32(Console.ReadLine());

            //if (p.Age != 0) Console.WriteLine(p.Age);

            //Console.WriteLine("Enter mobile number");
            //p.MobileNo = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine(p.MobileNo);

            //if(p.Age==0)
            //Console.WriteLine("Invlaid age");
            ////else 
            //    Console.WriteLine(p.Age);




            //Console.WriteLine("Hello world");
            //Products p = new Products();
            //Console.WriteLine("Enter Product id");
            //int prodid=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ener Name");
            //string prodname=Console.ReadLine();

            //Console.WriteLine("enter Product Price");
            //float price=Convert.ToSingle(Console.ReadLine());

            //p.AcceptData(prodid, prodname, price);


            //p.PrintData();

            ////3
            //Address address = new Address();

            //Console.WriteLine("Enter street No");
            //address.StreetNo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter street Name");
            //address.StreetName = Console.ReadLine();
            //Console.WriteLine("Enter city");
            //address.City = Console.ReadLine();
            //Console.WriteLine( "Enter Pincode");
            //address.Pincode = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Enter country");
            //address.Country = Console.ReadLine();//set

            //Console.WriteLine("Address:");
            //Console.WriteLine(address.StreetNo);//get
            //Console.WriteLine(address.StreetName);
            //Console.WriteLine(address.City);
            //Console.WriteLine(address.Pincode);
            //Console.WriteLine(address.Country);


            //address.AcceptData(10);
            //address.DisplayData();//10


        }
    }
}
