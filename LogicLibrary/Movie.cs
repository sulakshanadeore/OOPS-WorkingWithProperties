using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
  public  enum SeatType { 
    Recliner,
    Classic,
    Premium
    }

    public abstract class Theatre
    {
        public int TheatreID { get; set; }

        public DateTime BookingDate { get; set; }

        public abstract void Launch();

    }


    public class Drama:Movie
    {
        public new void BookTicket(string moviename)
        {
            Console.WriteLine($"Booking for {moviename} for the concert and drama");
        }

        public override void Launch()
        {
            Console.WriteLine("Launch Drama");
        }


    }

   public class Concert:Drama
    {

        public new void Launch()
        {
            //base.Launch();
            Console.WriteLine("Concert launch as well.. Something new coming up.....");
        }

    }


    public class TraditionalDrama : Concert 
    { 
   

       
    
    }
    public class Movie:Theatre
    {



        public void BookTicket(string moviename)
        {
            Console.WriteLine($"Booking for {moviename}");
        }

        public void BookTicket(string moviename, int cnt)
        {
            Console.WriteLine($"Booking for {moviename} , {cnt} tickets");
        }

        public double BookTicket(string moviename, int cnt, SeatType seatType)
        {
            float price = 0;
            double totalAmt = 0;


            switch (seatType)
            {
                case SeatType.Recliner:
                    price = 1000;
                    totalAmt = price * cnt;
                    break;
                case SeatType.Classic:
                    price = 500;
                    totalAmt = price * cnt;
                    break;
                case SeatType.Premium:
                    price = 700;
                    totalAmt = price * cnt;
                    break;
                default:
                    break;
            }

            return totalAmt;
        }

        public override void Launch()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Movie Launch");
        }
    }
}
