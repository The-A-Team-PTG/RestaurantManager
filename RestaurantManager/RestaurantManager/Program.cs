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
            serveMeal firstmeal = new serveMeal();
            Console.WriteLine(firstmeal);

          
            RestaurantManager newmeal = new RestaurantManager();
            newmeal.Meal();
            Console.WriteLine(newmeal);

            Console.Read();
        }
    }
}
