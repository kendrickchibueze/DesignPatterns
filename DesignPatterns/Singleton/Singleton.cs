using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{

    //Singleton as a creational design pattern ensures that only one object of its kind exists and provides a single point of access to it for any other code.



   
    // The Singleton should always be a 'sealed' class to prevent class
    // inheritance through external classes and also through nested classes.
    public sealed  class Singleton
    {

        private Singleton()
        {

        }

        private static Singleton _instance;



        public static Singleton GetInstance()
        {

            if(_instance == null )
            {
                _instance = new Singleton();    
            }
            return _instance;   

        }


        // Finally, any singleton should define some business logic, which can
        // be executed on its instance.
        public void someBusinessLogic()
        {
            // ...
        }


        public class Clienter
        {
            public static void Run()
            {
                // The client code.
                Singleton s1 = Singleton.GetInstance();

                Singleton s2 = Singleton.GetInstance();

                if (s1 == s2)
                {
                    Console.WriteLine("Singleton works, both variables contain the same instance.");
                }
                else
                {
                    Console.WriteLine("Singleton failed, variables contain different instances.");
                }
            }
        }
    }
}
