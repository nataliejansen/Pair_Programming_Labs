using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Pairing_Application
{
    internal class Student
    {
        static void Main(string[] args)
        {
            bool exit = false;
            ArrayList names = new ArrayList();

                Console.WriteLine("Enter a name: \n" +
                    "Press x when done.\n" +
                    "Press a to view list.");
            do
            {
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "x")
                {
                    exit = true;
                }
                else
                {
                    names.Add(input);
                }


            } while (!exit);

            Console.WriteLine("\n\n**** LIST OF USERS ****\n");
            foreach (var name in names)
            {
                Console.WriteLine(name); ;

            }

            Console.WriteLine("\n\n**** Grouped Users ****\n");
            Random rand = new Random();
            int randNbr = rand.Next(names.Length);
            List<string> grouped = new List<string>();
            foreach(var name in names)
	        {
                
              
                string name1 = names[randNbr];
                string name2 = names[randNbr + 1];
                string groupedName = name1 + " | " + name2;

                grouped.Add(groupedName);
	        }
            
            foreach (var group in grouped)
	        {

                Console.WriteLine(group);
	        }
            

           // Console.WriteLine(grouped);

           // for (int i = 0; i < names.Count(); i++)
           // {

               // Console.WriteLine(String.Join(" | ", names.Take(2));
//}


            
            
            #region KeyRead
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);//true-  intercept - you wont see what the user types.
                                  //false (default) -lets you see what user types
            #endregion


        }
    }
    

    
}
