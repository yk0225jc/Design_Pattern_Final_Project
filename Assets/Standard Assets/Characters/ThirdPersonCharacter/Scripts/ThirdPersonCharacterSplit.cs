using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThirdPersonCharacterHumble
{
    public class ThirdPersonCharacterSplit : MonoBehaviour, IThirdPersonCharacter
    {
        float m_TurnAmount;
        float m_ForwardAmount;
        Vector3 m_GroundNormal;
        bool m_IsGrounded;

        private ThirdPersonCharacterSplitController _thirdPersonCharacterSplitController;

        float IThirdPersonCharacter.m_TurnAmount { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        float IThirdPersonCharacter.m_ForwardAmount { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        bool IThirdPersonCharacter.m_IsGrounded { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        Vector3 IThirdPersonCharacter.m_GroundNormal { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Awake()
        {
            _thirdPersonCharacterSplitController = new ThirdPersonCharacterSplitController(this);
        }

        // Update is called once per frame
        void Update()
        {
            _thirdPersonCharacterSplitController.Move(new Vector3(2f, 0f), false, false, false);
        }
    }


}