using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    public class Program
    {
        static void Main(string[] args)
        {
            FoodMenu menu = new FoodMenu();
            double totalCost = 0.0;
            Dictionary<string, double> selectedItems = new Dictionary<string, double>();

            Console.WriteLine("-----------------Welcome to the Canteen Food Menu System!--------------------");
            Console.WriteLine(" Please enter employee name: ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Please enter your employee department: ");
            string department = Console.ReadLine();

            Console.WriteLine(".............Please select a day (Monday to Friday):............");
            string selectedDay = Console.ReadLine().ToLower();

            Dictionary<string, double> foodItems = menu.GetMenu(selectedDay);

            Console.WriteLine($" Food Menu for - {selectedDay} :");
            Console.WriteLine("--FoodItem - Price--");
            foreach (var item in foodItems)
            {
                Console.WriteLine($"{item.Key} : ${item.Value}");
            }
            while (true)
            {
                Console.WriteLine("Please select a food item or type 'exit' to finish:");
                string selectedItem = Console.ReadLine().ToLower();

                if (selectedItem.ToLower() == "exit")
                {
                    break;
                }

                if (foodItems.ContainsKey(selectedItem))
                {
                    selectedItems[selectedItem] = foodItems[selectedItem];
                    totalCost += foodItems[selectedItem];
                    Console.WriteLine($"{selectedItem} added to the order. Total cost: ${totalCost}");
                }
                else
                {
                    Console.WriteLine("Invalid food item. Please try again.");
                }
            }

            Console.WriteLine("------------------------------ Receipt:----------------------------");
            Console.WriteLine($"Employee Name: {employeeName}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine("Selected Items:");
            foreach (var item in selectedItems)
            {
                Console.WriteLine($"{item.Key}: ${item.Value}");
            }
            Console.WriteLine($"Total Cost: ${totalCost}");
            Console.ReadLine();
        }
    }
}
