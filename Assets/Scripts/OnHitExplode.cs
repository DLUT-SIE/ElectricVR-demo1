using System.Collections;
using System.Collections.Generic;
using NewtonVR;
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
				other.transform.parent.transform.parent.GetComponent<NVRHand> ().StartShake(1000);
			}
			catch(System.Exception e) {
				Debug.Log (e);
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.name.Equals ("trackhat")) {
			try{
				other.transform.parent.transform.parent.GetComponent<NVRHand> ().EndShake();
			}
			catch(System.Exception e)
			{
				Debug.Log (e);
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
