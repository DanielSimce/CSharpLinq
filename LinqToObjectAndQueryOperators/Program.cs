using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToObjectAndQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            //um.MaleStudents();
            //um.femaleStudents();
            //um.SortStudentByAge();
            //um.AllStudentsFromBeijingTech();
            um.StudenAndUniversityNameCollection();
            int[] someInts = { 34, 15, 48, 10, 5, 6, 3, 77, 90 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reverseInts = sortedInts.Reverse();

            foreach (var i in reverseInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            foreach (var i in reversedSortedInts)
            {
                Console.Write($"{i} ");
            }



           
          
    
         

            

            Console.ReadLine();

            
        }
    }
}
