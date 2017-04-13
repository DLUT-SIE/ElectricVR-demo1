using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIcontrol : MonoBehaviour {
	private Camera main_camera;
	private Text text;
	private Image img;
	private int current_text_level = 0;

	public bool GUI_on_start = false;

	// Use this for initialization
	void Start () {
		main_camera = GetComponent<Canvas> ().worldCamera;
		text = GetComponentInChildren<Text> ();
		img = GetComponentInChildren<Image> ();
		if (GUI_on_start == false) {
			text.enabled = false;
			img.enabled = false;
		}
	}

	public void set_black(bool should_black)
	{
		if (should_black == true) {
			main_camera.cullingMask = 1 << 5;
			img.enabled = true;
		} else {
			main_camera.cullingMask = -1;
			img.enabled = false;
		}
	}

	public void show_text(string s)
	{
		text.text = s;
		text.enabled = true;
	}

	public void hide_text()
	{
		text.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
