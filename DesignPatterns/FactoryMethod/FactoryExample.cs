using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DesignPatterns.FactoryMethod
{



//    The Factory design pattern is used when:

//A class cannot anticipate the type of objects it needs to create.
//    A class wants its subclasses to specify the objects it creates.
//The Factory pattern provides a way to encapsulate object creation by defining a separate factory object responsible for creating objects, rather than having the object creation code spread throughout the application.This promotes loose coupling between the classes involved in object creation, as the client code only needs to know about the factory and the interface of the objects it creates, without having to know about the specific classes that are instantiated.

//In other words, the Factory design pattern is all about encapsulating object creation and providing a unified interface for creating objects of different types, without specifying the concrete classes that will be instantiated.This allows for more flexibility and maintainability of the code, as new types of objects can be added easily without having to modify the existing code.




    internal class FactoryExample
    {

      
        public class SportsCar : ICar
        {
            public void Drive()
            {
                Console.WriteLine("Driving a Sports Car");
            }
        }

        public class FamilyCar : ICar
        {
            public void Drive()
            {
                Console.WriteLine("Driving a Family Car");
            }
        }

        public class CarFactory
        {
            public static ICar GetCar(string carType)
            {
                if (carType == "Sports")
                    return new SportsCar();
                else if (carType == "Family")
                    return new FamilyCar();

                throw new ArgumentException("Invalid car type");
            }
        }


        public class Cliently
        {
            public static  void Run()
            {
               
                    ICar car = CarFactory.GetCar("Sports");
                    car.Drive();

                    car = CarFactory.GetCar("Family");
                    car.Drive();
                
            }
        }

    }
}
