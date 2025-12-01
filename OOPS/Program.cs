using LogicLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ICustomer customer;

            //customer = new VIPCustomer();
            //customer.BrowseProducts();
            //customer.AddToCart();
            //customer.PlaceOrder();
            //customer.WriteReview();

            //Console.WriteLine("-------------");

            //customer = new RegularCustomer();
           
            //customer.BrowseProducts();
            //customer.AddToCart();
            //customer.PlaceOrder();
            //customer.WriteReview();


            ShowVideos v=new ShowVideos();
            //1
            v.HitLike();
            v.HitLike();
            Console.WriteLine(v.CntLike);

            Console.WriteLine("-------");
            

            ShowVideos v1=new ShowVideos();
            //1
            v1.HitLike();
            Console.WriteLine(v1.CntLike);


            Console.WriteLine("----------------");
            ShowVideos v2=new ShowVideos();     
            //1
            v2.HitLike();
            Console.WriteLine(v2.CntLike);
            Console.WriteLine(  "-------");


            //Drama drama=new Drama();
            // drama.Launch();
            // Console.WriteLine("------------------------");
            //Concert concert=new Concert();
            //concert.Launch();
            //concert.BookTicket("ABC");



            //GooglePay gpay = new GooglePay();
            //gpay.ConnectToBank();
            //gpay.Pay();


            //PhonePe pe=new PhonePe();
            //pe.ConnectToBank();
            //pe.Pay();


            // Movie m = new Movie();
            //double amt= m.BookTicket("Avatar", 3, SeatType.Recliner);
            // Console.WriteLine(amt);



            //Swiggy  swiggy = new Swiggy();
            //swiggy.OrderFood();

            // Books b = new Books(2, "Oliver Twist", 120);
            // DateTime issuedDate = new DateTime(2025, 10, 19);
            // DateTime returningdate=b.LendBook(2,issuedDate);
            // Console.WriteLine(returningdate);
            //double amt= b.CalculateFine();
            // Console.WriteLine("Fine amt=" + amt);


            // Console.WriteLine("---------------");

            // Novel novel = new Novel(1, "A Cup of Hope", 1000);
            // Console.WriteLine(novel.Bookid);
            // Console.WriteLine(novel.Name);
            // Console.WriteLine(novel.BookPages);
            //  DateTime today=DateTime.Now;
            // issuedDate = new DateTime(2025, 10, 19);
            //returningdate = novel.LendBook(1, issuedDate);
            //Console.WriteLine(returningdate);
            // amt = novel.CalculateFine();
            //Console.WriteLine("Fine amt=" + amt);




            //Employee employee = new Employee("Harish");


            //SavingAccount account = new SavingAccount();
            //account.AccountNo = 123;
            //account.CustomerName = "Jack";
            //account.City = "Banglaore";
            //account.Password = "Jack@123";

            //Console.WriteLine(account.AccountNo);
            //Console.WriteLine(account.CustomerName);
            //Console.WriteLine(account.City);
            //Console.WriteLine($"Initial Balance={account.Balance:C}");
            //account.Deposit(10000);
            //account.Deposit(20000);



            //Register r = new Register("JAck", "jack@gamil.com", "2342424","jakc1@gmail.com","BTECH","Pune");

            //Register r1 = new Register(name: "Jack", email: "gack@gmail.com", cellid: "2323234",alterEmailid:"hhh@gmail.com");


            //Register r2 = new Register("Jack", "gack@gmail.com", "2323234");






            //Employee e1 = new Employee(); 
            //Employee e2 = new Employee("Diksha");
            //Employee e3 = new Employee("Jack", "Mumbai");
            //Employee e4 = new Employee("Gauri", "Pune", 10);

            //Orders firstorder=new Orders();

            //Orders secondorder = new Orders(11);

            //Console.WriteLine("--------");
            //Orders thirdorder = new Orders(12, 101, 1000);



            //BankAccount account = new BankAccount();
            //account.AccountNo = 123;
            //account.CustomerName = "Jack";
            //account.City = "Banglaore";
            //account.Password = "Jack@123";

            //Console.WriteLine(account.AccountNo);
            //Console.WriteLine(account.CustomerName);
            //Console.WriteLine(account.City);
            //Console.WriteLine($"Initial Balance={account.Balance:C}");
            //account.Deposit(10000);
            //account.Deposit(20000);



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
