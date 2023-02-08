using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace DesignPatterns.Singleton
{


    //    The Singleton pattern is a design pattern that restricts a class to have only one instance, while providing a global point of access to that instance.This pattern is used to ensure that a class has only one instance, while providing a way to access that instance from anywhere in the application.

    //The Singleton pattern should be used when:

    //Only one instance of a class is required to control the action throughout the execution of the program.
    //Logging, caching, thread pool, and thread-safe objects are the examples of singleton classes.
    public sealed class NewSingleton
    {


        private static NewSingleton instance = null;


        // Object used to lock the creation of the Singleton instance, ensuring thread-safety
        private static readonly object lockObject = new object();

        private NewSingleton() { }

        public static NewSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    // Lock the code block to ensure that only one thread can create the instance
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new NewSingleton();
                        }
                    }
                }

                return instance;
            }
        }
    }

    
}
