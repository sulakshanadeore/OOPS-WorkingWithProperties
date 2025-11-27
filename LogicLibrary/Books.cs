using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Books
    {

        public int Bookid { get; set; }
        public string Name { get; set; }
        public int BookPages { get; set; }
        public Books(int bookid,string name,int pages)
        {
            this.Bookid = bookid;  
            this.Name = name;
            this.BookPages = pages;
                
        }


        public DateTime ReturnDate { get; set; }
        public DateTime Issudate { get; set; }
        public virtual DateTime LendBook(int bookid,DateTime issueDate)
        {
            //Usually 7 days is lending time
            Issudate = issueDate;
            ReturnDate= issueDate.AddDays(7);
            return ReturnDate;
        }

        public virtual void PrimeReaderMembership()
        {
            Console.WriteLine("You are a prime membership reader.....");


        }



        public double CalculateFine()
        {
            double fineamt=0;
            if (ReturnDate < DateTime.Now)
            {
                DateTime d1=DateTime.Now;
                DateTime d2 = Issudate.Date;
                // int days = DateTime.Now.Day - ReturnDate.Date.Day;//30()
                TimeSpan diff = d1 - d2;

                Console.WriteLine(diff.Days);
                if (diff.Days>0)
                {
                  fineamt =diff.Days * 10;
                }
            
            }
            return fineamt;
        
        }

    }

    public class Novel : Books 
    {

        public new void PrimeReaderMembership()
        {
            Console.WriteLine("2 books more every month for the novel reader");
        
        
        }


        public Novel(int bookid,string name,int pages):base(bookid,name,pages)
        {
        }
        public override DateTime LendBook(int bookid, DateTime issueDate)
        {
            return issueDate.AddDays(10);
        }


        public new double CalculateFine()
        {

            double fineamt = 0;
            if (ReturnDate < DateTime.Now)
            {
                DateTime d1 = DateTime.Now;
                DateTime d2 = Issudate.Date;
                // int days = DateTime.Now.Day - ReturnDate.Date.Day;
                TimeSpan diff = d1 - d2;
                Console.WriteLine(diff.Days);
                if (diff.Days > 0)
                {
                    fineamt = diff.Days * 15;
                }

            }
            return fineamt;
        }






    }

}
