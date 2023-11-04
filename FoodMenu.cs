using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    public class FoodMenu
    {
        private Dictionary<string, Dictionary<string, double>> weeklyMenu;

        public FoodMenu()
        {
            weeklyMenu = new Dictionary<string, Dictionary<string, double>>
        {
            { "monday", new Dictionary<string, double>
                {
                    { "rice", 25 },
                    { "dal", 20 },
                    { "chapathi", 15 }
            }
            },
             { "tuesday", new Dictionary<string, double>
                {
                    // Tuesday menu items and prices
                     { "rice", 25},
                    { "tomato", 20 },
                    { "dosa", 20 }
                }
            },
            { "wednesday", new Dictionary<string, double>
                {
                    // Wednesday menu items and prices
                     { "rice", 25},
                    { "potato", 20 },
                    { "puri", 25 }
                }
            },
                        { "thursday", new Dictionary<string, double>
                {
                    // Thursday menu items and prices
                    { "rice", 25},
                    { "eggCurry", 20 },
                    { "idle", 25 }
                }
            },

            { "friday", new Dictionary<string, double>
                {
                    // Friday menu items and prices
                     { "rice", 10.99 },
                    { "dal", 8.49 },
                    { "chapathi", 12.79 },
                {"sweet",25 }
                }
            }
        };
        }
        public Dictionary<string, double> GetMenu(string day)
        {
            if (weeklyMenu.ContainsKey(day))
            {
                return weeklyMenu[day];
            }
            else
            {

                throw new ArgumentException("Invalid day input. Please enter a valid day (Monday to Friday).");
            }
        }
    }
}
