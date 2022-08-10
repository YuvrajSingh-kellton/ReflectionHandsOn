using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Student
    {
        public int RollNo { get; set; }

        public string Name { get; set; }

        // No Argument Constructor
        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        // Parameterised Constructor
        public Student(int no, string naam)
        {
            RollNo = no;
            Name = naam;
        }

        // Method to Display Student Data
        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }

    }

}