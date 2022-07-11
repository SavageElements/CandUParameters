using System;
using System.Collections.Generic;
using System.Linq;

namespace CandUParameters
{
    class Program
    {
        static void Main(string[] args)
        {



            Employee<string> employee = new Employee<string>();
            employee.ID = 1234;
            employee.Things = new List<string> { "Blue Tie", "Pinstripe Suit", "Bowler Hat" };

            Employee<int> employee2 = new Employee<int>();
            employee2.ID = 5678;
            employee2.Things = new List<int>{ 1, 2, 3, 4, 5 };

            foreach (object obj in employee.Things)
            {
                Console.WriteLine(obj);
            }

            foreach (object obj in employee2.Things)
            {
                Console.WriteLine(obj);
            }

        }
    }
}


