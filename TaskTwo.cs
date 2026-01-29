using UnityEngine;

public class TaskTwo : MonoBehaviour
{
    //Book Settings
    public float coverPrice = 24.95f;
    public int numberOfCopies = 60;

    //Cost Settings
    public float wholesaleDiscount = 0.6f;
    public float baseShippingCost = 3f;
    public float additionalShippingPerCopy = 0.75f;

    //Run the calculations on start
    void Start()
    {
        CalculateAndLogResults();
    }

    // Calculate and log the wholesale cost and profit
    void CalculateAndLogResults()
    {
        float wholesaleCost = CalculateWholesaleCost();
        float shippingCost = CalculateShippingCost();
        float totalCost = CalculateTotalCost(wholesaleCost, shippingCost);
        float revenue = CalculateRevenue();
        float profit = CalculateProfit(revenue, totalCost);

        LogResults(wholesaleCost, profit);
    }

    // Calculate the wholesale cost
    float CalculateWholesaleCost()
    {
        return wholesaleDiscount * coverPrice * numberOfCopies;
    }
    // Calculate the shipping cost
    float CalculateShippingCost()
    {
        if (numberOfCopies <= 0)
            return 0f;

        return baseShippingCost + additionalShippingPerCopy * (numberOfCopies - 1);
    }
    // Calculate the total revenue
    float CalculateRevenue()
    {
        return coverPrice * numberOfCopies;
    }
    // Calculate the total cost
    float CalculateTotalCost(float wholesaleCost, float shippingCost)
    {
        return wholesaleCost + shippingCost;
    }
    // Calculate the profit
    float CalculateProfit(float revenue, float totalCost)
    {
        return revenue - totalCost;
    }
    // Log the results to the console
    void LogResults(float wholesaleCost, float profit)
    {
        Debug.Log($"Total wholesale cost: ${wholesaleCost:F2}");
        Debug.Log($"Total profit: ${profit:F2}");
    }
}
