using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeZoneDetect : MonoBehaviour {
	public GameObject GUI_text;
	private Text text;
	private bool LeftHand_inside, RightHand_inside;
	// Use this for initialization
	void Start () {
		text = GUI_text.GetComponent<Text> ();
		text.enabled = false;
		LeftHand_inside = true;
		RightHand_inside = true;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.name.Equals ("LeftHand"))
			LeftHand_inside = false;
		else if (col.name.Equals ("RightHand"))
			RightHand_inside = false;
		if(!LeftHand_inside || !RightHand_inside)
			text.enabled = true;
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
		if(LeftHand_inside && RightHand_inside)
			text.enabled = false;
		
	}	

	// Update is called once per frame
	void Update () {
		//Debug.Log ("working");
	}
}
