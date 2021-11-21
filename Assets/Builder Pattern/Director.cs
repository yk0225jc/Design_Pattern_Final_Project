//Written by Jiameng Zhou

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director
{
    public void Construct(AbstractAssembleCar builder)
    {
        builder.BuildBody();
        builder.BuildFrontBumper();
        builder.BuildTire();
    }
    
}
