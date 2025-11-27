using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Employee
    {
        public Employee()
        {
                
        }

        static int _empid = 0;
        public int Empid { get; private set; }
        public string Empname { get; set; }
        public string City { get; set; }

        public int Deptno { get; set; }
        public Employee(string name) {
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
