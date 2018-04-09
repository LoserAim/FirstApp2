using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp1
{
    public abstract class Course
    {
        public IList<Student> Students { get; set; }
        public IList<Instructor> Instructors { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return string.Format("Class Name: %s Class Number: %s", Name, Number);
        }


    }
}
