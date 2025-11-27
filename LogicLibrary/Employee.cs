using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{


    public class User
    {
        public string UserName { get; set; }

        public User()
        {
            
        }
        public User(string name)
        {
            this.UserName = name;
            Console.WriteLine($"User name and employee name is same, its , {this.UserName}");
        }

    }
    public class Employee:User
    {
        public Employee()
        {
                
        }

        static int _empid = 0;
        public int Empid { get; private set; }
        public string Empname { get; set; }
        public string City { get; set; }

        public int Deptno { get; set; }
        public Employee(string name):base(name)
                {
            _empid += 1;
            Empid = _empid;
            Empname = name;
            Console.WriteLine(Empid);
            Console.WriteLine(Empname);
        }

        public Employee(string name,string city):this(name)
        {
               this.City= city;
            Console.WriteLine(City);
        }

        public Employee(string name, string city,int deptid):this(name,city)
        {
                Deptno = deptid;
            Console.WriteLine(Deptno);
        }


    }
}
