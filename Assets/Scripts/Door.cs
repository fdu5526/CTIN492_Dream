using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	void OnTriggerExit (Collider other) {
		GetComponent<Collider>().enabled = true;
		GetComponent<Renderer>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
