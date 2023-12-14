using LearnDesignPatterns;

Singleton singletonA = Singleton.GetInstance();
Singleton singletonB = Singleton.GetInstance();
if (singletonA == singletonB)
{
    Console.WriteLine("They are the same");
}