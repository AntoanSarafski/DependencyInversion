using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Store
    {
        public string GetPromotionToday()
        {

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                return "MondayPromotion";
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return "FridayPromotion";
            }
            return "No promotion.";
        }
    }
}
