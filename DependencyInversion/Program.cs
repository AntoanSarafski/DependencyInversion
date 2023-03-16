using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine(store.GetPromotionToday());
            Console.WriteLine(store.GetPromotionTodayDI(DateTime.Now.AddDays(2)));
            Console.WriteLine(store.GetPromotionTodayDI(DateTime.Now.AddYears(7)));
        }
    }
}
