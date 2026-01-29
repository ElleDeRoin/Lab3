using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskOne : MonoBehaviour
{
    // Total amount to be split into bills
    public int total = 0;
    // Counters for each bill
    private int hundreds;
    private int fifties;
    private int twenties;
    private int tens;
    private int fives;
    private int ones;

    private void Start()
    {
        // Start the bill splitting process if total is greater than 0
        if (total > 0)
        {
            Debug.Log("Total amount to split: " + total);
            // Call the bill splitting loop
            billSplitLoop(total);
        }
        // Output the results
        Debug.Log("Hundreds: " + hundreds + ", Fifties: " + fifties + ", Twenties: " + twenties + ", Tens: " + tens + ", Fives: " + fives + ", Ones: " + ones);
        // Debug.Log("Fifties: " + fifties);
        // Debug.Log("Twenties: " + twenties);
        // Debug.Log("Tens: " + tens);
        // Debug.Log("Fives: " + fives);
        // Debug.Log("Ones: " + ones);
    }
    // Loops through the total amount and splits it into bills
    private void billSplitLoop(int totalMoney)
    {
        
        while (total > 0)
        {
            if (total > 100)
            {
                hundreds += billSplit(total, 100);
            }
            else if (total > 50)
            {
                fifties += billSplit(total, 50);
            }
            else if (total > 20)
            {
                twenties += billSplit(total, 20);
            }
            else if (total > 10)
            {
                tens += billSplit(total, 10);
            }
            else if (total > 5)
            {
                fives += billSplit(total, 5);
            }
            else if (total >= 1)
            {
                ones += billSplit(total, 1);
            }
        }
    }
    // Processes a single bill and updates the total amount
    private int billSplit(int totalMoney, int bill)
    {
        // Debug.Log("Processing bill: " + bill + " for total: " + total);
        total -= bill;
        // Debug.Log("New total after processing bill: " + total);
        return 1;
    }


}
