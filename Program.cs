using LearnDesignPatterns;

// Singleton singletonA = Singleton.GetInstance();
// Singleton singletonB = Singleton.GetInstance();
// if (singletonA == singletonB)
// {
//     Console.WriteLine("They are the same");
// }


Console.WriteLine("App: Launched on Android.");

ClientCode(new AndroidButtonCreator());

Console.WriteLine("");

Console.WriteLine("App: Launched on IOS.");

ClientCode(new IosButtonCreator());


// The client code works with an instance of a concrete creator, albeit
// through its base interface. As long as the client keeps working with
// the creator via the base interface, you can pass it any creator's
// subclass.
void ClientCode(Creator creator)
{
    Console.WriteLine(creator.ExampleOperation());
}