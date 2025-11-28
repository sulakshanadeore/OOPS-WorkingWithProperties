using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public interface ICustomer
    {
        void BrowseProducts();
       
        void AddToCart();
        void PlaceOrder();
        void WriteReview();

    }

    public class VIPCustomer : ICustomer
    {
        public void AddToCart()
        {
            Console.WriteLine("Adding items to cart");
        }

        public void BrowseProducts()
        {
            Console.WriteLine("Browsing all premium products");
        }

        public void PlaceOrder()
        {
            //  throw new NotImplementedException();
            Console.WriteLine("Place orders for PRime delivery");
        }

        public void WriteReview()
        {
            Console.WriteLine("Write a detailed review");
        }
    }

    public class RegularCustomer : ICustomer
    {
        public void AddToCart()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Adding items to cart");
        }

        public void BrowseProducts()
        {
            //  throw new NotImplementedException();
            Console.WriteLine("Browse all regular products");
        }

        public void PlaceOrder()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Place order for standard delivery");
        }

        public void WriteReview()
        {
            //  throw new NotImplementedException();
            Console.WriteLine("Short review ");
        }
    }

}
