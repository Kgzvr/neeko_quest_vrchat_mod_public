using VRC;
using VRC.SDKBase;
using UnityEngine;
using MelonLoader;

namespace uwuclara.PlayerHacks
{
    class FlyHack : uwuclara
    {

		public static bool jetPackEnabled { get; internal set; }
		public static bool flyEnabled { get; internal set; }
		private static bool justSwitchedfly;
		private static float flySpeedCurrent = 8f;


		//taken from promovement5

		internal static void jetPack()
        {

			if (jetPackEnabled && Jumping() && !Networking.LocalPlayer.IsPlayerGrounded())
			{
				Vector3 velocity = Networking.LocalPlayer.GetVelocity();
				velocity.y = Networking.LocalPlayer.GetJumpImpulse();
				Networking.LocalPlayer.SetVelocity(velocity);
			}

		}

		internal static void fly()
        {

			if (!flyEnabled)
			{

				if (justSwitchedfly)
				{

					justSwitchedfly = false;
					Physics.gravity = new Vector3(0f, -9.81f, 0f);

				}

			}
			else if (flyEnabled && !(Physics.gravity == Vector3.zero))
			{

				justSwitchedfly = true;
				Physics.gravity = Vector3.zero;

			}

			if (flyEnabled && !(Player.prop_Player_0 == null))
			{

				float num = Input.GetKey(KeyCode.LeftShift) ? (Time.deltaTime * flySpeedCurrent) : (Time.deltaTime * (flySpeedCurrent / 3));

				if (Player.prop_Player_0.field_Private_VRCPlayerApi_0.IsUserInVR())
				{

					if (Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical") < -0.5f)
					{
						Player.prop_Player_0.transform.position -= camera().up * num;
					}
					if (Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical") > 0.5f)
					{
						Player.prop_Player_0.transform.position += camera().up * num;
					}
					if (Input.GetAxis("Vertical") != 0f)
					{
						Player.prop_Player_0.transform.position += camera().forward * (num * Input.GetAxis("Vertical"));
					}
					if (Input.GetAxis("Vertical") == 0f)
					{
						Networking.LocalPlayer.SetVelocity(Vector3.zero);
					}
					if (Input.GetAxis("Horizontal") != 0f)
					{
						Player.prop_Player_0.transform.position += camera().transform.right * (num * Input.GetAxis("Horizontal"));
					}

				}

			}

		}

		internal static void setFlySpeedToggle(bool value)
		{

			if (value)
			{

				flyEnabled = true;
				setFlySpeed(flySpeedCurrent);

			}
			else
			{

				flyEnabled = false;
				resetFlySpeed();

			}

		}

		private static void setFlySpeed(float speed)
		{

			flySpeedCurrent = speed;

		}

		internal static void resetFlySpeed()
		{

			var flySpeed = 8f;

			setFlySpeed(flySpeed);

		}

		internal static void updateFlySpeed(float update)
		{

			if (update >= 0f)
			{
				
				flySpeedCurrent = flySpeedCurrent + update;

				Config.ConfManager.flySpeedValue.Value = flySpeedCurrent;

				MelonPreferences.Save();

				if (flyEnabled)
				{
					setFlySpeed(flySpeedCurrent);
				}
				
			}
			
		}

		private static bool Jumping()
		{

			return VRCInputManager.Method_Public_Static_ObjectPublicStSiBoSiObBoSiObStSiUnique_String_0("Jump").field_Private_Single_0 != 0f;

		}

		private static Transform camera()
		{
			return VRCPlayer.field_Internal_Static_VRCPlayer_0.transform;
		}

	}

}
