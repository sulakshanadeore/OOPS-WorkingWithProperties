using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
   public abstract class UPIPayment
    {
        public void ConnectToBank()
        {

            Console.WriteLine("Connected successfully....");
        }

        public abstract void Pay();
        

    }

    public class GooglePay : UPIPayment
    {
        public override void Pay()
        {
            Console.WriteLine("Payment done by Gpay...");
        }
    }

    public class PhonePe : UPIPayment
    {
        public override void Pay()
        {
            Console.WriteLine("Payment done by PhonePe...");
        }
    }


}
