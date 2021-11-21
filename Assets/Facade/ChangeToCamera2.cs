using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToCamera2 : MonoBehaviour, CameraChangeable
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;

    // Start is called before the first frame update
    public void Start()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
        }
    }
}
