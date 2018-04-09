using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp1
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public override string ToString()
        {
            return string.Format("Person Name: %s, %s Person ID: %s", Last, First, Id);
        }
    }
}
