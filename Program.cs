using LearnDesignPatterns;

/* SINGLETON */
// Singleton singletonA = Singleton.GetInstance();
// Singleton singletonB = Singleton.GetInstance();
// if (singletonA == singletonB)
// {
//     Console.WriteLine("They are the same");
// }


/* FACTORY METHOD */
// Console.WriteLine("App: Launched on Android.");
// ClientCode(new AndroidButtonCreator());
// Console.WriteLine("");
// Console.WriteLine("App: Launched on IOS.");
// ClientCode(new IosButtonCreator());


// The client code works with an instance of a concrete creator, albeit
// through its base interface. As long as the client keeps working with
// the creator via the base interface, you can pass it any creator's
// subclass.
// void ClientCode(Creator creator)
// {
//     Console.WriteLine(creator.ExampleOperation());
// }

/* FACADE */
// Facade facade = new Facade(new WaterSubsystem {}, new ElectricalSubsystem {});
// Console.WriteLine(facade.FacadeModeA());

var subject = new Subject();

var observerA = new ConcreteObserverA();

subject.Attach(observerA);

var observerB = new ConcreteObserverB();

subject.Attach(observerB);

subject.ExampleOperation();

subject.Detach(observerB);