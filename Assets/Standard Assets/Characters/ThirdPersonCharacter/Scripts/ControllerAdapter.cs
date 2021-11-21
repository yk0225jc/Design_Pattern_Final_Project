using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public abstract class ControllerAdapter : MonoBehaviour, IController
{
    // Adapted Third Person User Control call
    ThirdPersonUserControl thirdPersonUserControl = new AdaptedThirdPersonUserControl();

    // Update is called once per frame
    public void Update()
    {
        thirdPersonUserControl.Update();
    }
}
