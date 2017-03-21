using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : MonoBehaviour {
	public float rotate_speed = 1f;
	public Space relative = Space.Self;
	public Vector3 rotate_direction = Vector3.down;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotate_direction * rotate_speed, relative);
	}
}
