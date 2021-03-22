using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantManager soup = new RestaurantManager();
            soup.Meal("soup", "patatos", 2, "carots", 4, "salt", 1, "2021-02-16");

            Console.ReadLine();
        }
    }
}
