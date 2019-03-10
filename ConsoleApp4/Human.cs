using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Abstraction
{
    abstract class Human
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public abstract void SayHello();
        public override string ToString()
        {
            return Name+" from "+Country;
        }
    }
    class Ukrainian:Human
    {
        public Ukrainian(string name)
        {
            Name = name;
            this.Country = "UA";
        }
        public override void SayHello() => Console.WriteLine("Привіт!");
    }
    class American:Human
    {
        public American(string name)
        {
            Name = name;
            Country = "USA";
        }
        public override void SayHello() => Console.WriteLine("Hi!");
    }
    class Italian:Human
    {
        public Italian(string name)
        {
            Name = name;
            Country = "ITA";
        }
        public override void SayHello() => Console.WriteLine("Ciao!");
    }
}
