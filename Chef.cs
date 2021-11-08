using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritpr
{
    class Chef
    {
        /// methods
       
       
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");

        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");

        }
        //when we specify thisas virtual it means that this
        //method can be overridden in any subclasses
        public virtual void MakeSpecialDish() 
        {
            Console.WriteLine("The Chef makes bbq ribs");
        
        
        }






    }
}
