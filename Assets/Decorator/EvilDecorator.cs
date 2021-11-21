using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilDecorator : MushroomDecorator
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lt.color = (Color.red);
    }
}
