using UnityEngine;
using System.Collections;

public class OnTriggerDestroy : MonoBehaviour {
	public GameObject destroyTarget;
	public GameObject enableTarget;

	// Use this for initialization
	void Start () {
		if (enableTarget != null) {
			enableTarget.SetActive(false);
		}
	}
	
	void OnTriggerExit (Collider other) {
		Destroy(destroyTarget);
		if (enableTarget != null) {
			enableTarget.SetActive(true);
		}
 	}
}
