using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		ControlCursor ();
	}

	void ControlCursor(){
		if (Input.GetKeyDown (KeyCode.Tab)) {
			if (Cursor.lockState == CursorLockMode.Locked) {
				Cursor.lockState = CursorLockMode.None;
			} else {
				Cursor.lockState = CursorLockMode.Locked;
			}
		}
	}

}//class















