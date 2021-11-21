using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float yMovement = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(xMovement, 0.0f, yMovement);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(xMovement, 0.0f, yMovement);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(xMovement, 0.0f, yMovement);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(xMovement, 0.0f, yMovement);
        }
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }

    }

}
