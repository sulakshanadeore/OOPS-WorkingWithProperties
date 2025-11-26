using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LogicLibrary
{
    public class Address
    {
        //4
        //int _streetNo;
        //string _streetName;
        //string _city;
        //string _country;
        //long _pincode;

        //3
        //public void AcceptData(int streetNo)
        //{ 
        //_streetNo = streetNo;
        //}


        //3
        //public void DisplayData()
        //{
        //    Console.WriteLine(_streetNo);
        //}

        //5---


        //Smart method(Property)----accept data(set) and display it(get)
        private int _streetNo;//variable/backing field
        public int StreetNo
        {
            set { _streetNo = value; }//setter block--value is keyword used for any datatype acceptance
            get { return _streetNo; }//getter block
        }


        private string _streetName;

        public string StreetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }


        //propfull--press tab 2 times
        private string _city;//Variables by default private

        public string City//Properties are public by default
        {
            get { return _city; }
            set { _city = value; }
        }

        private long _pincode;

        public long Pincode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }

        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }










    }
}
