using System;
using System.Collections.Generic;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Glass
    {
        public int Capacity { get; } = 20;
    }

    public class Pub
    {
        public Glass ServeBeer()
        {
            return new Glass();
        }
    }
}
