using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnCubes : MonoBehaviour
{

    public GameObject myPrefab;
    public GameObject mySecondPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Aggregate aggr = new Aggregate();

        aggr[0] = 7;
        aggr[1] = 8;
        aggr[2] = 9;
        aggr[3] = 89;
        aggr[4] = 7;
        aggr[5] = 8;
        aggr[6] = 9;


        IIterator iter = aggr.GetIterator();
        //Loops until isDone==false
        int step = 0;
        for (int i = iter.FirstItem; iter.IsDone == false; i = iter.NextItem)
        {
            Instantiate(myPrefab, new Vector3(UnityEngine.Random.Range(0f, 70.0f), 4.7f, UnityEngine.Random.Range(10f, 70.0f)), 
                Quaternion.Euler(0.0f, Random.Range(0.0f, 360.0f), 0.0f));

            Instantiate(mySecondPrefab, new Vector3(UnityEngine.Random.Range(0f, 70.0f), 3.75f, UnityEngine.Random.Range(10f, 70.0f)),
    Quaternion.Euler(0.0f, Random.Range(0.0f, 360.0f), 0.0f));

            step++;
            Console.WriteLine(i.ToString());
        }
        Console.ReadLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
