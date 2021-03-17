using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToObjectAndQueryOperators
{
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"Univerity {Name} with id {Id}");
        }

    }
}
