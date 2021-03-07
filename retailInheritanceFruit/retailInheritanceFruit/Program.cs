using System;

namespace retailInheritanceFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit("Macintosh", .5);
            Console.WriteLine("Kind: {0}, cost per dozen : {1}", apple.Kind, apple.GetCost());
        }
    }
    class Apple // base class
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
    }
    class Fruit : Apple // derived class
    {
        public Fruit(string k, double c)
        { // Pulling data from one class using it in another is effectively how Inheritance 
            Kind = k;
            Cost = c;
        }
        public string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
}
