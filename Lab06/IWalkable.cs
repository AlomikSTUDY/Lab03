using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    internal interface IWalkable
    {
        public interface IWalkable
        {
            public void Walk();
        }
        public class Dog : Mammal, IWalkable
        {
        
            public void Walk()
            {
                Console.WriteLine("I walk on a leash.");
            }
        }
    }
}
