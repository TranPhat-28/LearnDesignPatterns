using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDesignPatterns
{
    // The Builder interface specifies methods for creating the different parts of the Product objects
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }

    public class Builder : IBuilder
    {
        // The Builder classes follow the Builder interface and provide
        // specific implementations of the building steps. Your program may have
        // several variations of Builders, implemented differently.

        private Product _product = new Product();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public Builder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // All production steps work with the same product instance.
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }

        // Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Product GetProduct()
        {
            Product result = this._product;
            this.Reset();
            return result;
        }
    }

    public class Product
    {
        private List<object> _parts = new List<object>();
        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);
            // removing last ",c"
            return "Product parts: " + str + "\n";
        }
    }
}

// Now we can use BuildPartA(), BuildPartB(), BuildPartC() to build
// all kinds of different products