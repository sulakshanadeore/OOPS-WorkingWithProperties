using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Register
    {
        public string Name { get; private set; }
        public string EmailID { get; private set; }

        public string AlternateEmail { get; private set; }

        public string City { get; private set; }

        public string Qualification { get; private set; }
        public string Phone { get;private set; }

        //public Register(string name,string email,string cellid)
        //{
        //    Name=name;  
        //    EmailID=email;  
        //    Phone=cellid;
        //}

        //public Register(string name, string email, string cellid,  string alterEmailid=""):this(name,email,cellid)
        //{
        //    AlternateEmail=alterEmailid;    
        //}

        //public Register(string name, string email, string cellid, string alterEmailid="",string Qual="" ): this(name,email,cellid,alterEmailid)
        //{ 
        //Qualification=Qual; 
        
        //}
        public Register(string name, string email, string cellid, string alterEmailid="", string Qual="",string City="")
        {
           this.City = City;     
        }




    }
}
