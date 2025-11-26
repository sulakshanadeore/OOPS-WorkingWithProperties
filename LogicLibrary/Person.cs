using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LogicLibrary
{
    public class Person
    {
		private string _pname;

		public string PersonName
		{
			get { return _pname; }
			set 
			{
				
				if(!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value) && value.Length>5)

				_pname = value;
                //if (!string.IsNullOrEmpty(_pname) && !string.IsNullOrWhiteSpace(_pname) && _pname.Length > 5)
               else
                {
                               Console.WriteLine("Something is wrong...either null or empty or spaces or length is less than 5");
                }
            }
		}

		private long _mbileno;

		public long MobileNo
		{
			get { return _mbileno; }
			set
			{
				if (value.ToString().Length == 10)

					_mbileno = value;
				else
				{
                    Console.WriteLine("Invalid mobile number");
				}
			}
		
		}






		private int _age;
		public int Age
		{
			get {
				return _age;
                  
			}
				set 
			{
				if (value < 0 || value < 18)
				{
					Console.WriteLine("Age not valid");
				}
				else
				{
					_age = value;
				}

			}
		}


	}
}
