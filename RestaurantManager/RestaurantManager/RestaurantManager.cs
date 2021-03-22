using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class RestaurantManager
    {
        public void Meal(string nmae, string pr1, int qu1, string pr2, int qu2, string pr3, int qu3, string date)
        {
            Console.WriteLine("What do you want?");
            if (qu1 >= 0)
            {
                Console.WriteLine(nmae + " " + pr1 + " " + qu1 + " " + pr2 + " " + qu2 + " " + pr3 + " " + qu3 + " " + date);
            }
            else if (qu1 <= 0)
            {

                Console.WriteLine("Cannot create " + nmae + " because " + pr1 + " does ot exist");
            }

        }
    }
}
