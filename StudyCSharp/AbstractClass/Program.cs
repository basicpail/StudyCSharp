using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethod");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethod");
        }

        public abstract void AbstractMethodA();
    }

        class Derived : AbstractBase
        {
            public override void AbstractMethodA()
            {
                Console.WriteLine("Derived.AbstractMethodA");
                PrivateMethodA();
            }
        }
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }

    }
        
    
}
