using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryAfterTime : MonoBehaviour {
	public float timer = 1f;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, timer);
	}
	

}
