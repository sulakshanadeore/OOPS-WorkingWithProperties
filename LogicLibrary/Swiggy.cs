using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Swiggy
    {

        public void OrderFood()
        {
            Console.WriteLine("Opening trending foods near you");
        }
        public void OrderFood(string item)
        {
            Console.WriteLine("Ordering " + item);
        }

        public void OrderFood(string item, int qty)
        {
            Console.WriteLine("Ordering " + item + " with Quantity " + qty);
        }

        public void OrderFood(int qty, string item)
        {
            Console.WriteLine("Ordering " + item + " with Quantity " + qty);
        }

        public float OrderFood(int qty, string item,int price)
        {
            Console.WriteLine("Ordering " + item + " with Quantity " + qty);
            return price * qty;
        }

        public void OrderFood(string[] item)
        {

        }

    }
}
