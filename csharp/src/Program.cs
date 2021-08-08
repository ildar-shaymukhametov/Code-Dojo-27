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
        public int RemainingLiquid { get; private set; }
        public bool IsEmpty => RemainingLiquid == 0;

        public void Fill(int amount)
        {
            RemainingLiquid += amount;
        }

        public void Drink()
        {
            RemainingLiquid -= 1;
        }

        public void Quaff()
        {
            RemainingLiquid -= 4;
        }

        public void DownInOne()
        {
            RemainingLiquid = 0;
        }

        public void FillByLandlord()
        {
            Fill(20);
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
