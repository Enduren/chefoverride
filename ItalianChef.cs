using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritpr
{
    //Lets say the Italian Chef can make everything the other chefs can
    //make this is where we can use Inheritance
    //All you have to do is place a : and then name the other class in this case its Chef
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.Write("The Chef makes pasta");

        }
        //override means we can change the method from the superclass
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef make chicken parm");


        }
    }
}
