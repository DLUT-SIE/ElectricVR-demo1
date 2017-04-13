using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosCollideAction : MonoBehaviour {
	private GUIcontrol gui;
	public void action()
	{
		if (gui == null)
			gui = GameObject.Find ("Canvas").GetComponent<GUIcontrol> ();
		gui.set_black (true);
		gui.show_text ("警告:您已进入非法区域!");
	}

	public void deaction()
	{
		if(gui == null)
			gui = GameObject.Find ("Canvas").GetComponent<GUIcontrol> ();
		gui.set_black (false);
		gui.hide_text ();
	}

}
