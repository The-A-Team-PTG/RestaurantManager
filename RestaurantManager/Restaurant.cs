using System;

public class Class1
{
    public Restaurant() : RestaurantManger
    {

     private string name;
    private string address;
    private int UIN;
    private string MRP;
    private int initialCapital;





    public Restaurant(string n, string a, int U, string M, int i)
    {
        this.name = n;
        this.address = a;
        this.UIN = U;
        this.MRP = M;
        this.initialCapital = i;
    }

    public Restaurant()
    {
        this.name = "PizzaCodexia";
        this.address = "CityPalaceCenter";
        this.UIN = 205427773;
        this.MRP = "IvanYonkov";
        this.initialCapital = 1000;
    }



    public override string ToString()
    {
        return ("" + name + "  " + address + "  " + UIN + "  " + MRP + "  " + initialCapital);
    }

}
}
