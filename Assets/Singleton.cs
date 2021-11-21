using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instance = null;
    public List<GameObject> aListOfGameObjects;

    private Singleton()
    {
        aListOfGameObjects = new List<GameObject>();
    }

    // static method to create instance of Singleton class 
    public static Singleton getInstance()
    {
        if (instance == null)
            instance = new Singleton();

        return instance;
    }

}