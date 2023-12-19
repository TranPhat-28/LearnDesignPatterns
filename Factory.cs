using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDesignPatterns
{
    // The Creator's subclasses usually provide the implementation for the factory method.
    abstract class Creator
    {
        public abstract IButton FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string ExampleOperation()
        {
            // Call the factory method to create a Button object.
            var button = FactoryMethod();

            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with" + button.Press();

            return result;
        }
    }

    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    class AndroidButtonCreator : Creator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override IButton FactoryMethod()
        {
            return new AndroidButton();
        }
    }

    class IosButtonCreator : Creator
    {
        public override IButton FactoryMethod()
        {
            return new IosButton();
        }
    }

    // The Button interface declares the operations that all concrete products must implement.
    public interface IButton
    {
        string Press();
    }

    // Concrete Products provide various implementations of the Product
    // interface.
    class AndroidButton : IButton
    {
        public string Press()
        {
            return "Hello Android";
        }
    }

    class IosButton : IButton
    {
        public string Press()
        {
            return "Hello IOS";
        }
    }
}