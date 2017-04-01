using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeZoneDetect : MonoBehaviour {
	private GUIcontrol gui;
	public bool LeftHand_inside, RightHand_inside;
	// Use this for initialization
	void Start () {
		gui = FindObjectOfType<GUIcontrol> ();
		LeftHand_inside = true;
		RightHand_inside = true;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.name.Equals ("LeftHand"))
			LeftHand_inside = false;
		else if (col.name.Equals ("RightHand"))
			RightHand_inside = false;
		if (!LeftHand_inside || !RightHand_inside)
			gui.show_text ("警告:您已进入危险区域！");
	}

	void OnTriggerStay(Collider col)
	{
	}

	void OnTriggerExit(Collider col)
	{
		if (col.name.Equals ("LeftHand"))
			LeftHand_inside = true;
		else if (col.name.Equals ("RightHand"))
			RightHand_inside = true;
		if (LeftHand_inside && RightHand_inside)
			gui.hide_text ();
		
	}	

	// Update is called once per frame
	void Update () {
		//Debug.Log ("working");
	}
}
