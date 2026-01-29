using UnityEngine;
using UnityEngine.UI;

public class TaskTwo : MonoBehaviour

{
    //editable price and number of copies
    public float coverPrice = 24.95f;
    public int numberOfCopies = 60;

    //calls function on start
    void Start()
    {
        Calculate();
    }

    public void Calculate()
    {     

        // Wholesale cost
        float wholesaleCost = 0.6f * coverPrice * numberOfCopies;

        // Shipping cost
        float shippingCost = 3f + 0.75f * (numberOfCopies - 1);

        float totalCost = wholesaleCost + shippingCost;

        // Revenue & profit
        float revenue = coverPrice * numberOfCopies;
        float profit = revenue - totalCost;

        Debug.Log($"Total wholesale cost: ${wholesaleCost:F2}");
        Debug.Log($"Total profit: ${profit:F2}");
    }
}

