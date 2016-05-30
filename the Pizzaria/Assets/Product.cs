using UnityEngine;
using System.Collections;
using System;

public abstract class Product {

    // Use this for initialization
    public string name;
    protected float basePrice;
    public abstract float GetPrice();

}



public class Pizza : Product {

    private ArrayList toppings;
    public string discription;

    public override float GetPrice()
    {
        float totalPrice = basePrice;
        foreach (Topping topping in toppings)
        {
            totalPrice += topping.price;
        }
        return totalPrice;
    }

    public void addTopping(Topping topping)
    {
        toppings.Add(topping);
    }

}

public class SoftDrink : Product
{
    public SoftDrink(string name,float price)
    {
        this.name = name;
        this.basePrice = price;
    }
    public override float GetPrice()
    {
        return basePrice;
    }
}
