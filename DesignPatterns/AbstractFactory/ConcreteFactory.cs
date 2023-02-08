using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{

    //Abstract Factory defines an interface for creating all distinct products but leaves the actual product creation to concrete factory classes.

    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }



    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of product A1";
        }
    }




    public class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of B1 collaborating with {result}";
        }

        public string UsefulFunctionB()
        {
            return "The result of product B1";
        }
    }


    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }


    public class ConcreteProductA2: IAbstractProductA{

        public string UsefulFunctionA()
        {
            return "The result of product A2";
        }
    }


    public class ConcreteProductB2 : IAbstractProductB {

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of B2 collaborating with {result}";
        }

        public string UsefulFunctionB()
        {
            return "The result of product B2";
        }



    }


    public class Client
    {

        public static void Run()
        {
            //client code can work with any concrete factory class
            Console.WriteLine("Client: Testing client code with the first factory type...");


            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();


            Console.WriteLine("Client: Testing client code with the second factory type...");

            ClientMethod(new ConcreteFactory2());
        }


        public static void ClientMethod(IAbstractFactory factory)
        {

            var productA = factory.CreateProductA();

            var productB = factory.CreateProductB();


            Console.WriteLine(productB.UsefulFunctionB());

            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));

        }
    }

}


