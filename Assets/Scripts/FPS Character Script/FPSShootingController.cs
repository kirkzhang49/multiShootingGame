﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class FPSShootingController : NetworkBehaviour {
	private Camera mainCam;

	private float fireRate = 15f;
	private float nextTimeToFire = 0f;

	[SerializeField]
	private GameObject concrete_impact,blood_Impact;

	public float damageAmount = 15f;

	// Use this for initialization
	void Start () {
		mainCam = transform.Find("FPS View").Find("FPS Camera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		Shoot ();
	}

	void Shoot(){
		if (Input.GetMouseButtonDown (0) && Time.time > nextTimeToFire) {
			nextTimeToFire = Time.time + 1f / fireRate;
			RaycastHit hit;
			if (Physics.Raycast (mainCam.transform.position, mainCam.transform.forward, out hit)) {

				if (hit.transform.tag == "Enemy") {
					CmdDealDamage (hit.transform.gameObject, hit.point, hit.normal);
					print("damage got");
				} else {
					Instantiate(concrete_impact,hit.point,Quaternion.LookRotation(hit.normal));
				}
			}
		}
	}

	[Command]
	void CmdDealDamage(GameObject obj, Vector3 pos, Vector3 roation)
	{
		obj.GetComponent<PlayerHealth> ().TakeDamage (damageAmount);

		Instantiate (blood_Impact, pos, Quaternion.LookRotation (roation));
	}

}//Class











