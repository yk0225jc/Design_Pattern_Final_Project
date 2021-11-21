using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThirdPersonCharacterHumble
{
    public interface IThirdPersonCharacter
    {
        float m_TurnAmount { get; set; }
        float m_ForwardAmount { get; set; }
        bool m_IsGrounded { get; set; }
        Vector3 m_GroundNormal { get; set; }
    }
}
