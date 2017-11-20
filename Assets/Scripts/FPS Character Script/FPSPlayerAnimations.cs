using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class FPSPlayerAnimations : NetworkBehaviour {


	private Animator anim;

	private string MOVE = "Move";
	private string VELOCITY_Y = "VelocityY";
	private string CROUCH = "Crouch";
	private string CROUCH_WALK = "CrouchWalk";

	private string STAND_SHOT = "StandShoot";
	private string CROUCHSHOOT = "CrouchShoot";
	private string RELOAD = "Reload";
	// Use this for initialization

	public RuntimeAnimatorController animController_Pistol,animConroller_MachineGun;

	private NetworkAnimator netWorkAnim;

	void Awake () {
		anim = GetComponent<Animator> ();
		netWorkAnim = GetComponent<NetworkAnimator> ();
	}
	
	public void Movement (float magnitude){
		anim.SetFloat (MOVE, magnitude);
	}

	public void PlayerJump (float velocity)
	{
		anim.SetFloat (VELOCITY_Y, velocity);
	}

	public void PlayerCrouch(bool isCrouching)
	{
		anim.SetBool (CROUCH,isCrouching);
	}

	public void PlayerCrouchWalk (float magnitude)
	{
		anim.SetFloat (CROUCH_WALK, magnitude);
	}
	public void Shoot(bool isStanding){
		if (isStanding) {
			anim.SetTrigger (STAND_SHOT);
			netWorkAnim.SetTrigger (STAND_SHOT);
		} else {
			anim.SetTrigger (CROUCHSHOOT);
			netWorkAnim.SetTrigger (CROUCHSHOOT);
		}
	}
	public void ReloadGun(){
		anim.SetTrigger (RELOAD);
		netWorkAnim.SetTrigger (RELOAD);
	}
	public void ChangeController (bool isPistol)
	{
		if (isPistol) {
			anim.runtimeAnimatorController = animController_Pistol;
		} else {
			anim.runtimeAnimatorController = animConroller_MachineGun;
		}
	}

}//class























