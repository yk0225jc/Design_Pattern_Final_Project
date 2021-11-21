//Written by Jiameng Zhou

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public bool a = false;
    public GameObject g;
    List<GameObject> all = new List<GameObject>();
    int numberOfCar;
    int numberOfTire;

    public void ConcreteCarA()
    {
        Director director1 = new Director();
        AbstractAssembleCar redCar = new ConcreteCarA();
        director1.Construct(redCar);
        Product redCarA = redCar.GetResult();
        redCarA.Show();
    }
    public void CloseShow()
    {
        a = true;
    }
    public void Move()
    {
        foreach (var item in all)
        {
            item.transform.Translate(Vector3.forward * Time.deltaTime * 1.0f);
        }
    }

    public void ConcreteCarBuildBody()
    {
        GameObject go = Object.Instantiate(
            Resources.Load("RMCar12_Static_EU") as GameObject,
            new Vector3(0.17f, 3.2f, 0.87f), Quaternion.identity);
        all.Add(go);
        numberOfCar++;
        //go.transform.SetParent(all[numberOfCar - 1].transform);
        Debug.Log("Car-A Body Created");
    }
    public void ConcreteCarBuildTire()
    {
        //Front Left Tire
        GameObject go = Object.Instantiate(
           Resources.Load("RMCar12_WheelRearRight") as GameObject,
           new Vector3(0.9f, 3.5f, 2.12f), Quaternion.identity);
        //Front right Tire
        GameObject go2 = Object.Instantiate(
           Resources.Load("RMCar12_WheelRearRight") as GameObject,
           new Vector3(-0.5f, 3.5f, 2.17f), Quaternion.identity);
        //Back Left Tire
        GameObject go3 = Object.Instantiate(
           Resources.Load("RMCar12_WheelRearRight") as GameObject,
           new Vector3(-0.5f, 3.5f, -0.22f), Quaternion.identity);
        //Back Right Tire
        GameObject go4 = Object.Instantiate(
            Resources.Load("RMCar12_WheelRearRight") as GameObject,
            new Vector3(0.9f, 3.5f, -0.22f), Quaternion.identity);
        all.Add(go);
        all.Add(go2);
        all.Add(go3);
        all.Add(go4);
        numberOfTire++;
        go.transform.SetParent(all[numberOfCar - 1].transform);
        go2.transform.SetParent(all[numberOfCar - 1].transform);
        go3.transform.SetParent(all[numberOfCar - 1].transform);
        go4.transform.SetParent(all[numberOfCar - 1].transform);

        Debug.Log("Car Tires Created");
    }

    public void ConcreteCarBuildHead()
    {
        GameObject go = Object.Instantiate(
            Resources.Load("RedCarHead1") as GameObject,
            new Vector3(0.17f, 3.2f, 0.87f), Quaternion.identity);
        go.transform.SetParent(all[numberOfCar - 1].transform);


    }
    void Update()
    {
        if (a == true)
        {
            Move();
        }
    }

}
