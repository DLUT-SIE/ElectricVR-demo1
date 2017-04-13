using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using NewtonVR;

public class GameControl : MonoBehaviour {
	private static string current_scene = "start";
	private static string last_scene = "start";
	private static AsyncOperation async_op;

	private GUIcontrol gui;

	public NVRHand[] hands;
	// Use this for initialization
	void Start () {
		gui = FindObjectOfType<GUIcontrol> ();
		Object[] init_objects = GameObject.FindObjectsOfType (typeof(GameObject));
		foreach (GameObject go in init_objects)
			DontDestroyOnLoad (go);
		LOAD_SCENE ("main2");
	}

	public static void LOAD_SCENE(string scene_name, bool ASYNC = false)
	{
		if(ASYNC)
			async_op = SceneManager.LoadSceneAsync (scene_name);
		else
			SceneManager.LoadScene (scene_name);
		last_scene = current_scene;
		current_scene = scene_name;
	}

	public static void GAME_OVER()
	{
		LOAD_SCENE ("end");
	}
	
	// Update is called once per frame
	void Update () {
		if (async_op != null) {
			if (async_op.isDone == false) {
				gui.show_text ("正在载入场景: " + 100 * async_op.progress + "%");
			} else {
				gui.hide_text ();
				async_op = null;
			}
		}
		foreach (NVRHand hand in hands) {
			if (GameControl.current_scene == "end" && hand.UseButton != null && hand.UseButtonDown) {
				gui.show_text ("正在重新载入场景");
				LOAD_SCENE (GameControl.last_scene, true);
			}
		}
	}
}
