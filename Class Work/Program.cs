using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work
{
    public class animal
    {
        //property - global scope
        public int NoofLegs;

        //int hairs;//automatic assigned as a private property

        //main function - local scope

        //syntax of a method
        //access specifier return type method name(parameters)

        public void Sound(string sound)
        {
            Console.WriteLine("The sound of the animal is " + sound);
        }

    }
}
