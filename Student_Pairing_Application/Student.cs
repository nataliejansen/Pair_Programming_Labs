using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Pairing_Application
{
    internal class Student
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a student's name");

            string Name = Console.ReadLine().ToLower().Trim();

            List<string> students = new List<string>();
            students.Add(Name);



        }
    }

    
}
