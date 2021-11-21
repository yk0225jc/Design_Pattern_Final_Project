using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToCamera3 : MonoBehaviour, CameraChangeable
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;

    // Start is called before the first frame update
    public void Start()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }
    }
}
