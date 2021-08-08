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
        public int Amount { get; private set; }
        public bool IsEmpty => Amount == 0;

        public void Fill(int amount)
        {
            Amount += amount;
        }
    }

    public class Pub
    {
        public Glass ServeBeer()
        {
            var glass = new Glass();
            glass.Fill(20);
            return glass;
        }
    }
}
