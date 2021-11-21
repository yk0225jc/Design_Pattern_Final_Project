using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThirdPersonCharacterHumble
{
    public class MockPlayer : IThirdPersonCharacter
    {
        public float m_TurnAmount { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float m_ForwardAmount { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool m_IsGrounded { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Vector3 m_GroundNormal { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}


