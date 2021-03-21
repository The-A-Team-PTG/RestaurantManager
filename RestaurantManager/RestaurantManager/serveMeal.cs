using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class serveMeal
    {

    private string name;
    private string product1;
    private int quantity1;
    private string product2;
    private int quantity2;
    private string product3;
    private int quantity3;
    private string date;

        public serveMeal(string n, string p1, int q1, string p2, int q2, string p3, int q3, string d)
        {
            this.name = n;
            this.product1 = p1;
            this.quantity1 = q1;
            this.product2 = p2;
            this.quantity2 = q2;
            this.product3 = p3;
            this.quantity3 = q3;
            this.date = d;
        }

        public serveMeal()
        {
            this.name = "omlette";
            this.product1 = "eggs";
            this.quantity1 = 2;
            this.product2 = "flour";
            this.quantity2 = 1;
            this.product3 = "cheese";
            this.quantity3 = 1;
            this.date = "2021-03-18";

        }

        public override string ToString()
        {
            return ("" + name + "  " + product1 + "  " + quantity1 + "  " + product2 + "  " + quantity2 + " " + product3 + " " + quantity3 + " " + date);
        }
    }
}
