using System;

namespace Inheritpr
{
    class Program
    {
        static void Main(string[] args)
        {
            //create superclass
            Chef chef = new Chef();
            chef.MakeSpecialDish();
            //now make the ItlianChef make chicken subclass
            //after you changed chef class to virtual and
            //ItalianChef to overridde now have them make their special dish
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();
        }
    }
}
