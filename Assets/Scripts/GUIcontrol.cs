using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIcontrol : MonoBehaviour {
	private Text text;
	private int current_text_level = 0;

	public bool GUI_on_start = false;

	// Use this for initialization
	void Start () {
		text = GetComponentInChildren<Text> ();
		if (GUI_on_start == false) {
			text.enabled = false;
		}
	}

	public void show_text()
	{
		text.enabled = true;
	}

	public void show_text(string s, int level = 0)
	{
		if (level >= current_text_level) {
			current_text_level = level;
			text.text = s;
		}
		show_text ();
	}

	public void hide_text(int level = 0)
	{
		if (level < current_text_level)
			return;
		current_text_level = 0;
		text.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
