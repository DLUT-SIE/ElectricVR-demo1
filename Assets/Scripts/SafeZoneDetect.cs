using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeZoneDetect : MonoBehaviour {
	public GameObject GUI_text;
	private Text text;
	// Use this for initialization
	void Start () {
		text = GUI_text.GetComponent<Text> ();
		Debug.Log ("init:" + text);
		text.enabled = false;
	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("in");
		//if (col.gameObject.name == "DangerZone") {
		//	text.enabled = true;
		//}
	}

	void OnTriggerStay(Collider col)
	{
	}

	void OnTriggerExit(Collider col)
	{
		Debug.Log ("out");
		//if (col.gameObject.name == "DangerZone") {
		//	text.enabled = false;
		//}
	}	

	// Update is called once per frame
	void Update () {
		Debug.Log ("working");
	}
}
