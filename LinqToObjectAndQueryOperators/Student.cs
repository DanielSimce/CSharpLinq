using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToObjectAndQueryOperators
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foreigh Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {Name} with id {Id},Gender {Gender} and age {Age} from university with the Id {UniversityId} ");
        }

    }
}
