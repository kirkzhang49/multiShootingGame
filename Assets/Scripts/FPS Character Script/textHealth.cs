using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class textHealth : NetworkBehaviour {

	public Text Mytext; 



	[SyncVar]
	public float health = 100f;
	// Use this for initialization

	void Awake(){
		Mytext = gameObject.GetComponent<Text>();
		Mytext.text = health.ToString ("R");
	}

	public void TakeDamage (float damage) {
		if (!isServer) {
			return;
		}
		health -= damage;
		Mytext.text = health.ToString ("R"); 
		print (Mytext.text);
		//print("damage got");
		if (health <= 0f) {
			Destroy (gameObject);
		}
	}

}//Class

