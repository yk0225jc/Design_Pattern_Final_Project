//Written by Jiameng Zhou
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteCarA : AbstractAssembleCar
{
    private Product product = new Product();
    public override void BuildBody()
    {
        GameObject go = Object.Instantiate(Resources.Load("RMCar12_Static_EU") as GameObject,
            new Vector3(2f, 0, 7f), Quaternion.identity);
        product.Add("Car Body added");
    }

    public override void BuildFrontBumper()
    {
        GameObject go = Object.Instantiate(Resources.Load("RedCarHead1") as GameObject,
            new Vector3(2f, 0, 7f), Quaternion.identity);
        product.Add("Car-A Head Created");
    }

    public override void BuildTire()
    {
        GameObject go = Object.Instantiate(Resources.Load("RedCarTire1") as GameObject,
            new Vector3(2f, 0, 7f), Quaternion.identity);
        product.Add("Car-A Tire Created");
    }

    public override Product GetResult()
    {
        Debug.Log("--- Result ---");
        return product;
    }
}
