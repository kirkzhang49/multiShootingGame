using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerHealth : NetworkBehaviour {

	[SyncVar]
	public float health = 100f;
	// Use this for initialization
	public void TakeDamage (float damage) {
		if (!isServer) {
			return;
		}
		health -= damage;

		print("damage got");
		if (health <= 0f) {
			Destroy (gameObject);
		}
	}

}//Class






