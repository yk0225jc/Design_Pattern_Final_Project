using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingShroom : Strategy
{
    public int walkspeed;
    public float obstacleRange = 3.0f;
    private bool alive;
    public float damage = -5f;
    public GameObject player;
    public GameObject enemy;
    public Light lt;



    public int speed(int aspeed)
    {
        int speed = aspeed;
        return speed;
    }
    private void Start()
    {
        walkspeed = speed(2);
        lt.color = (Color.white);       
        
    }
    void Update()
    {
        
        
        
        
        
        
        var distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance < 100)
        {
            transform.Translate(0, 0, walkspeed * Time.deltaTime);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                if (hit.distance < obstacleRange)
                {
                    GameObject hitObject = hit.transform.gameObject;

                    if (hitObject == player)
                    {

                    }
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }


}
