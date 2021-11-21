using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToCameraOne : MonoBehaviour, CameraChangeable
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;

    // Start is called before the first frame update
    public void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
        }
    }
}
