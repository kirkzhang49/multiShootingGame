using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSWeapon : MonoBehaviour {

	private GameObject muzzleFlash;

	void Awake () {
		muzzleFlash = transform.Find ("MuzzleFlash").gameObject;
		muzzleFlash.SetActive (false);
	}
	public void Shoot()
	{
		StartCoroutine (TurnOnMuzzleFlashOn());
	}
	IEnumerator TurnOnMuzzleFlashOn(){
		muzzleFlash.SetActive (true);
		yield return new WaitForSeconds (0.1f);
		muzzleFlash.SetActive (false);
	}

}//Class


















