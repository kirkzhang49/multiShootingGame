using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerHealth : NetworkBehaviour {


	public RectTransform healthBar;
	public const float maxHealth = 100f;
	[SyncVar(hook="onDamage")] public float health = maxHealth;
	// Use this for initialization
	public void TakeDamage (float damage) {
		if (!isServer) {
			return;
		}
		health -= damage;
		healthBar.sizeDelta = new Vector2 (health, healthBar.sizeDelta.y);

		print("damage got");
		if (health <= 0f) {
			Destroy (gameObject);
		}

	}

	void onDamage(float curHealth)
	{
		healthBar.sizeDelta = new Vector2 (curHealth, healthBar.sizeDelta.y);
	}

}//Class






