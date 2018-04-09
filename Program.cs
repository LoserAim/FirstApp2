using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var brad = new Student
            {
                First = "Bradley",
                Last = "Bob",
                Id = 1234,
                Major = "Computer"
            }

            var lucas = new Instructor
            {
                First = "Lucas",
                Last = "Cordova",
                Department = "CSET",
                Salary = 12.00

            }
        }
    }
}
