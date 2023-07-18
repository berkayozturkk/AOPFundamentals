using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public virtual void Add(int id,string firstName,string lastName)
        {
            //Console.WriteLine("Method body start");

            //Console.WriteLine($"\t Id : {id}");
            //Console.WriteLine($"\t firstName : {firstName}");
            //Console.WriteLine($"\t lastName : {lastName}");

            //Console.WriteLine("Method body end");
            Console.WriteLine("Added.");

        }
    }
}
