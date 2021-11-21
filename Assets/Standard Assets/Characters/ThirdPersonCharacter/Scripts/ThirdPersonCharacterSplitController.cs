using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

namespace ThirdPersonCharacterHumble
{
	public class ThirdPersonCharacterSplitController : ThirdPersonCharacter
	{
		private IThirdPersonCharacter _thirdPersonCharacter;

		public ThirdPersonCharacterSplitController(IThirdPersonCharacter thirdPersonCharacter)
		{
			_thirdPersonCharacter = thirdPersonCharacter;
		}

		public void Move(Vector3 move, bool crouch, bool jump, bool pack)
		{

			// convert the world relative moveInput vector into a local-relative
			// turn amount and forward amount required to head in the desired
			// direction.
			if (move.magnitude > 1f) move.Normalize();
			move = transform.InverseTransformDirection(move);
			CheckGroundStatus();
			move = Vector3.ProjectOnPlane(move, _thirdPersonCharacter.m_GroundNormal);
			_thirdPersonCharacter.m_TurnAmount = Mathf.Atan2(move.x, move.z);
			_thirdPersonCharacter.m_ForwardAmount = move.z;

			ApplyExtraTurnRotation();

			// control and velocity handling is different when grounded and airborne:
			if (_thirdPersonCharacter.m_IsGrounded)
			{
				HandleGroundedMovement(crouch, jump, pack);
			}
			else
			{
				HandleAirborneMovement();
			}

			ScaleCapsuleForCrouching(crouch);
			PreventStandingInLowHeadroom();

			// send input and other state parameters to the animator
			UpdateAnimator(move);
		}
	}

}
