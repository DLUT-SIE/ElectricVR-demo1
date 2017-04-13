using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollide : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		PosCollideAction action = other.gameObject.GetComponent<PosCollideAction> ();
		if (action != null)
			action.action ();
	}

	void OnTriggerExit(Collider other)
	{
		PosCollideAction action = other.gameObject.GetComponent<PosCollideAction> ();
		if (action != null)
			action.deaction ();
	}
}
