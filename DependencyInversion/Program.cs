using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine(store.GetPromotionToday());
        }
    }
}
