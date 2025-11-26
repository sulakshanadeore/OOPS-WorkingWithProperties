using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Products
    {
        //Variables---Members
        int _productid;

        string _productname;

        float _price;

        public void AcceptData(int productid,string name,float price)//parameters
        {
            _productid = productid;
            _productname = name;
            _price = price;
        }

        public void PrintData() {
            Console.WriteLine(_productid);
            Console.WriteLine(_productname);
            Console.WriteLine(_price);
        }







    }
}
