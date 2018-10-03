using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {

    private int [] pillsInInventory;



    public Inventory()
    {

        PillsInInventory = new int[5];

    }

    public void AddToInventory(PillType pill)
    {
        PillsInInventory[(int)pill]++;
    }
    


    public int[] PillsInInventory
    {
        get
        {
            return pillsInInventory;
        }

        set
        {
            pillsInInventory = value;
        }
    }

    public int CalculatePenaltyPoints(Inventory inv)
    {
        int error = 0;
        for (int i = 0; i < PillsInInventory.Length; i++)
            error += PillsInInventory[i] - Mathf.Abs(inv.PillsInInventory[i]);
        return error * 10;
    }




}

public enum PillType
{

    Goodnightol,
    Xtacin,
    Happillin,
    Aliventillin,
    Antipanicizole

}


