using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public enum employeeType
    {
        Chief,
        Manager,
        Contributor
    }

    public class Employee
    {
        public string Name { get; set; }

        public employeeType Type { get; set; } 

        public Employee(string name, employeeType type)
        {
            this.Name = name;
            this.Type = type;
        }       

        public override string ToString()
        {
            return Name + " (" +  Type + ")";
           
            //Console.WriteLine("{0} ({1})", Name, Type);
        }

    }
}
