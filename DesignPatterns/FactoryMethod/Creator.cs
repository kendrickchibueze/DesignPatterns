using DesignPatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.FactoryMethod
{


            //The Factory Method defines a method, which should be used 
            //    for creating objects instead of using a direct constructor call(new operator).
            //    Subclasses can override this method to change the class of objects that will be created.
    abstract class Creator
    {

        public abstract IProduct FactoryMethod();



        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "Creator: The creator's code has just worked with" + product.Operation();

            return result;
        }

        class ConcreteCreator1 : Creator
        {


            public override IProduct FactoryMethod()
            {
                return new ConcreteProduct1();
            }

        }


        class ConcreteCreator2 : Creator
        {
            public override IProduct FactoryMethod()
            {
                return new ConcreteProduct2();
            }
        }


        class ConcreteProduct1 : IProduct
        {
             public string Operation()
            {
                return "{Result of concrete product 1}";
            }
        }


        class ConcreteProduct2 : IProduct {


            public string Operation()
            {
                return "{Result of concrete product 2}";
            }
        }


        public class ClientApp
        {
            public static  void Run2()
            {
                Console.WriteLine("App: Launched with the ConcreteCreator1.");
                ClientCode(new ConcreteCreator1());

                Console.WriteLine("");

                Console.WriteLine("App: Launched with the ConcreteCreator2.");
                ClientCode(new ConcreteCreator2());
            }

            // The client code works with an instance of a concrete creator, albeit
            // through its base interface. As long as the client keeps working with
            // the creator via the base interface, you can pass it any creator's
            // subclass.
            public  static void ClientCode(Creator creator)
            {
                
                Console.WriteLine("Client: I'm not aware of the creator's class," +
                    "but it still works.\n" + creator.SomeOperation());
                
            }
        }

    }
}
