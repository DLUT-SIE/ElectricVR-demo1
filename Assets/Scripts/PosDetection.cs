using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosDetection : MonoBehaviour {

	private GameObject pos_obj;
	// Use this for initialization
	void Start () {
		pos_obj = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		pos_obj.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		Destroy(pos_obj.GetComponent<MeshRenderer>());
		pos_obj.GetComponent<SphereCollider> ().isTrigger = true;
		pos_obj.AddComponent<PosCollideAction> ();
		DontDestroyOnLoad (pos_obj);
	}
	
	// Update is called once per frame
	void Update () {
		pos_obj.transform.position = transform.position;
	}
}
