using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;

public class AdaptedThirdPersonUserControl : ThirdPersonUserControl
{
    //ThirdPersonUserControl x = new ThirdPersonUserControl();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void IController.Update()
    //{
    //    if (!x.m_Jump)
    //    {
    //        x.m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
    //    }
    //    // get button down different then jump returns true if pressed
    //    if (!x.m_Pack)
    //    {
    //        x.m_Pack = CrossPlatformInputManager.GetButtonDown("Cancel");
    //    }
    //}

    public void Update(GameObject x)
    {
        if (!m_Jump)
        {
            m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
        }
        // get button down different then jump returns true if pressed
        if (!m_Pack)
        {
            m_Pack = CrossPlatformInputManager.GetButtonDown("Cancel");
        }
    }
}
