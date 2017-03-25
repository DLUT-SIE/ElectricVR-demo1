using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitExplode : MonoBehaviour {

	public GameObject explosion;

	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter(Collider other){
		if (other.name.Equals ("trackhat")) {
			try{
				explosion.transform.position = other.transform.position;
				explosion.GetComponent <Detonator> ().Explode ();
			}
			catch(System.Exception e) {
				Debug.Log (e);
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
