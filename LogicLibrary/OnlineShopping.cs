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




    interface I1
    {
        void M1();
    
    }

    interface I2:I1 { }
    interface I3 { }

    class A : Movie, I2, I3
    {
        public void M1()
        {
            throw new NotImplementedException();
        }
    }


    interface IViewer
    {
        void HitLike();
        void Share();

        void Comment(string review);

           
    
    }

    interface ICreator
    {

        void Create();
        void Edit();

    
    }

    public class ShowVideos : ICreator,IViewer
     {

        public int CntLike { get; private set; }

        
        public void Comment(string review)
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void HitLike()
        {
           // throw new NotImplementedException();
           CntLike++;   
        }

        public void Share()
        {
            throw new NotImplementedException();
        }
    }



}
