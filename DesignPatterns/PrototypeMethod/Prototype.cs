using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypeMethod
{
    public abstract class Prototype
    {
        public int X { get; set; }
        public int Y { get; set; }


        // Clone method which creates a shallow copy of the object
        public Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1()
        {
            X = 1;
            Y = 2;
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2()
        {
            X = 3;
            Y = 4;
        }
    }



    public class Client
    {
        public void Main()
        {
            
            ConcretePrototype1 prototype1 = new ConcretePrototype1();
            
            ConcretePrototype1 prototype1Clone = (ConcretePrototype1)prototype1.Clone();

            
            ConcretePrototype2 prototype2 = new ConcretePrototype2();
            
            ConcretePrototype2 prototype2Clone = (ConcretePrototype2)prototype2.Clone();
        }
    }


}
