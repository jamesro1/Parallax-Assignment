using UnityEngine;
using System.Collections;

public class Detect : MonoBehaviour {

	public Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.name == "2 - big-foot") {
			anim.SetBool ("StartSprite", true);
		}
	}
}
