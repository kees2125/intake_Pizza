using UnityEngine;
using System.Collections;

public class Order : MonoBehaviour {
    private ArrayList products;

    public float GetPrice()
    {
        float total = 0;
        foreach(Product p in products)
        {
            total += p.GetPrice();
        }
        return total;
    }
    
}
