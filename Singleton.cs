using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDesignPatterns
{
    // Singleton should always be a 'sealed' class to prevent inheritance
    public sealed class Singleton
    {
        // Constructor should always be private to prevent public call with the 'new' keyword
        private Singleton()
        {

        }

        // The Singleton's instance is stored in a static field to be kept track of
        private static Singleton _instance;

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static Singleton GetInstance()
        {

            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        // Finally some logic, which can be executed on its instance
        public string ExampleMethod()
        {
            return "Hello from the only instance of Singleton";
        }
    }
}

// Client's code
// Singleton singletonA = Singleton.GetInstance();
// Singleton singletonB = Singleton.GetInstance();
// if (singletonA == singletonB)
// {
//     Console.WriteLine("They are the same");
// }