using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDesignPatterns
{
    // Subject: The one that is observed, notifies the observers when there is a change
    public interface IObserver
    {
        // Receive update from subject
        void Update(IObserverSubject subject);
    }

    public interface IObserverSubject
    {
        // Attach an observer
        void Attach(IObserver observer);

        // Detach an observer
        void Detach(IObserver observer);

        // Notify all observers about an event
        void Notify();
    }

    // The Subject owns some important state and notifies observers when the
    // state changes.
    public class Subject : IObserverSubject
    {
        // The subject's state
        public string State { get; set; } = "Nothing";

        // List of subscribers
        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached a new observer.");

            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);

            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying all observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void ExampleOperation()
        {
            Console.WriteLine("Subject: Updating state...");

            this.State = "New state";

            Console.WriteLine("Subject: State changed to: " + this.State);

            this.Notify();
        }
    }



    // Some example classes for Observer
    class ConcreteObserverA : IObserver
    {
        public void Update(IObserverSubject subject)
        {
            if ((subject as Subject).State == "New state")
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(IObserverSubject subject)
        {
            if ((subject as Subject).State == "New state")
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}