using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.ImplementedClasses
{
    public class Filter:IOptions
    {
        public Filter() { }
        public void Blur() { Console.WriteLine("Blur Filter added."); }

        public void disable()
        {

        }

        public void enable()
        {

        }

        public void Gradient() { Console.WriteLine("Gradient Filter added."); }
    }
}
