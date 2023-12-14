using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDesignPatterns
{
    public class PersonPrototype
    {
        // These are the properties of the object
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        // Method to create a shallow copy of the object
        public PersonPrototype ShallowCopy()
        {
            // Object.MemberwiseClone() creates a shallow copy of the object
            return (PersonPrototype)this.MemberwiseClone();
        }

        // Method to create a deep copy of the object
        public PersonPrototype DeepCopy()
        {
            PersonPrototype clone = (PersonPrototype)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }

    // Info classes
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
}