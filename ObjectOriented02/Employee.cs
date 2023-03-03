using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented02
{
    internal class Employee
    {
        //in the class there are "members of the class"
         // 1. Data members (where we store the data)

        public int Id { get; set; }           //these are the properties of object

        public string Name { get; set; }

        public string Address { get; set; }


        // 2. Member functions

        public void GetData()
        {
            Console.WriteLine("Please enter the value for employee Id ");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for employee Name ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Please enter the value for employee Address ");
            this.Address = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Id = " +this.Id);
            Console.WriteLine("Name = " +this.Name);
            Console.WriteLine("Address = " + this.Address);
        }

    }
    // this is the class now we have to create an object for this class
}
