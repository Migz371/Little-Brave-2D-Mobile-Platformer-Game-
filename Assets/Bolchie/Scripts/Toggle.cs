using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//toggles player in demo scene//
public class Toggle : MonoBehaviour {

	public GameObject ch;
	public GameObject chr;
	public bool onoff;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.X)) {
			if (!onoff) {
				ch.SetActive (true);
				chr.SetActive (false);
				onoff = true;
			} else {
				ch.SetActive (false);
				chr.SetActive (true);
				onoff = false;
			}
		}
	}
}
