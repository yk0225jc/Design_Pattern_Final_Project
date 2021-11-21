//Written by Jiameng Zhou
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product
{
    //Add car parts to a list
    private List<string> partsList = new List<string>();
    //Add car Parts
    public void Add(string part)
    {
        partsList.Add(part);
    }
    //Use console to print the car building progress
    public void Show()
    {
        Debug.Log("--- Car building progress ---");
        foreach(string part in partsList)
        {
            Debug.Log(part);
        }
    }
}
