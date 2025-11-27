using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Customers
    {
		private int _custid;

		public int CustomerID
		{
			get { return _custid; }
			set { _custid = value; }
		}

		private string _custname;

		public string CustomerName
		{
			get { return _custname; }
			set { _custname = value; }
		}

		//Readonly

		private string _city="Pune";
		public string City
		{
		get { return _city; }
		private set { _city = value; }
		}
		public Customers()
		{ }
		public Customers(int custid, string custname, string custcity)
		{ 
		CustomerID=custid;
			CustomerName=custname;
			City=custcity;
		
		
		}




		//Writeonly  property
		private int _pin;
		public int Pin
		{
			private get { return _pin; }
			set { _pin = value; }
		}

		private bool _forgotPin;

		public bool ForgotPin
		{
			get { return _forgotPin; }
			set { 
				if(value==true)
				_forgotPin = value;
                Console.WriteLine("enter your secret answer");
				string secretanswer = Console.ReadLine();
				if (secretanswer == "123456789")
				{
                    Console.WriteLine(_pin);

				}
			}
		}




	}
}
