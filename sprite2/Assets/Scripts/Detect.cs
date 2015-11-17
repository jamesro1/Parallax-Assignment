using UnityEngine;
using System.Collections;

public class Detect : MonoBehaviour {

	public Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.name == "2 - big-foot")
						anim.SetBool ("Bool", true);
	}
}
