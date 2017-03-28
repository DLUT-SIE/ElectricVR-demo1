using System.Collections;
using System.Collections.Generic;
using NewtonVR;
using UnityEngine;

public class OnHitExplode : MonoBehaviour {

	public GameObject explosion;
	private bool explode_finish;

	// Use this for initialization
	void Start () {
		explode_finish = true;
	}
	IEnumerator explode()
	{
		Instantiate (explosion);
		explode_finish = false;
		yield return new WaitForSeconds (3f);
		explode_finish = true;
	}

	void OnCollisionEnter(Collision collision){
		Transform NVRplayer = collision.transform.parent;
		if (NVRplayer.name.Equals ("NVRPlayer") && explode_finish) {
			StartCoroutine (explode());
		}
	}

	void OnCollisionStay(Collision collision){
		Transform NVRplayer = collision.transform.parent;
		Transform Hand = null;
		if (NVRplayer.name.Equals ("NVRPlayer")) {
			if (collision.transform.name.StartsWith ("Left"))
				Hand = NVRplayer.FindChild ("LeftHand");
			else if (collision.transform.name.StartsWith ("Right"))
				Hand = NVRplayer.FindChild ("RightHand");
			if (Hand != null)
				Hand.GetComponent<NVRHand> ().StartShake(1500);
		}
	}

	void OnCollisionExit(Collision collision)
	{
		Transform NVRplayer = collision.transform.parent;
		Transform Hand = null;
		if (NVRplayer.name.Equals ("NVRPlayer")) {
			if (collision.transform.name.StartsWith ("Left"))
				Hand = NVRplayer.FindChild ("LeftHand");
			else if (collision.transform.name.StartsWith ("Right"))
				Hand = NVRplayer.FindChild ("RightHand");
			if (Hand != null)
				Hand.GetComponent<NVRHand> ().EndShake ();
		}
	}

	/*
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
	}*/

	// Update is called once per frame
	void Update () {
		
	}
}
