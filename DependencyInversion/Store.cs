using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Store
    {
        public string GetPromotionToday()
        {

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)   // WE CAN NOT TEST THIS CODE, UNTIL MONDAY :( THIS IS UNACCEPTABLE !!!
            {
                return "MondayPromotion";
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)   // WE CAN NOT TEST THIS CODE, UNTIL FRIDAY :( THIS IS UNACCEPTABLE !!!
            {
                return "FridayPromotion";
            }
            if (DateTime.Now.Year == 2030)                    // WE CAN NOT TEST THIS CODE, UNTIL 2030 :(( THIS IS UNACCEPTABLE !!!
            {
                return "PromoYear";
            }
            return "No promotion.";
        }

        public string GetPromotionTodayDI(DateTime dateToday)
        {

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)   // WE CAN NOT TEST THIS CODE, UNTIL MONDAY :( THIS IS UNACCEPTABLE !!!
            {
                return "MondayPromotion";
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)   // WE CAN NOT TEST THIS CODE, UNTIL FRIDAY :( THIS IS UNACCEPTABLE !!!
            {
                return "FridayPromotion";
            }
            if (DateTime.Now.Year == 2030)                    // WE CAN NOT TEST THIS CODE, UNTIL 2030 :(( THIS IS UNACCEPTABLE !!!
            {
                return "PromoYear";
            }
            return "No promotion.";
        }
    }
}
