using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Orders
    {
        static int _orderid = 0;
        public int OrderNo { get; private set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public string Amt { get; set; }

        public Orders()
        {
            _orderid += 1;
            OrderNo = _orderid;
            Console.WriteLine($"Your order id ={OrderNo}");

        }
        public Orders(int custid)
        {
            _orderid += 1;
            OrderNo = _orderid;
            CustomerID = custid;
            Console.WriteLine($"Your order id ={OrderNo}");
            Console.WriteLine($"CustomerID= {custid}");
        }
        public Orders(int custid,int productid,int qty):this(custid)
        {
            //_orderid += 1;
            //OrderNo = _orderid;
            // CustomerID = custid;
            // Console.WriteLine($"Your order id ={OrderNo}");
            Console.WriteLine(productid);
            Console.WriteLine(qty);
            
        }




    }
}
