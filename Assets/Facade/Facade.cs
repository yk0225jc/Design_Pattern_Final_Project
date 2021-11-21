using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    ChangeToCameraOne cam1 = new ChangeToCameraOne();
    ChangeToCamera2 cam2 = new ChangeToCamera2();
    ChangeToCamera3 cam3 = new ChangeToCamera3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam1.Update();
        cam2.Update();
        cam3.Update();
    }
}
