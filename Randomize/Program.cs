using System;
using System.Collections.Generic;

namespace Randomize
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] allemployees = new string[] {"Aaron John", "Emilia Agetorp", "Elias Agetorp", "Linnea Scott", "Adam Theodor", "Benson Edward", "Benney Svensson", "Lisa Li", "Tony Ganegård", "SamuelAgetorp", "Yen Agetorp", "Chris Rufus", "Eva Francis", "Nina Kim"};
            foreach (var employee in allemployees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();
            allemployees.Randomize();
            foreach (var employee in allemployees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();
            int numOfgroups = 3;
            int group_num = 0;
            List<string> randomorderedEmployees = new List<string>();
            for (int i = 0; i < allemployees.Length; i++)
            {
                randomorderedEmployees.Add($"{group_num}  {allemployees[i]}"); 
                group_num = ++group_num % numOfgroups;
                Console.WriteLine(randomorderedEmployees[i]);
            }



        }
    }
}
