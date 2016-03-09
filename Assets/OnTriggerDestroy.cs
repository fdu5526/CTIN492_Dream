using UnityEngine;
using System.Collections;

public class OnTriggerDestroy : MonoBehaviour {
	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerExit (Collider other) {
		Destroy(target);
	}
}
