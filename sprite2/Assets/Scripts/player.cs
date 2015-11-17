using UnityEngine;
using System.Collections;

public class player : MonoBehaviour                   //  Attached to 'GoodGuy1'
{
	public Vector3 startPosition;
	public float speed = 50f;
	//public float gravity = 20.0f;
	private Vector3 moveDirection = Vector3.zero;
	private Animator anim;
	// public GameObject projectile;                                                              //  projectile is referenced from the 'projectile' script

	void Start () {
		startPosition = transform.position;
		anim = GetComponent <Animator> ();
	}

	 void Update() {

	
	 }

	void FixedUpdate (){                                                                         //  Movement for Player
		                                                                                         //  Player will rotate to new direction as opposed to instantanous switch 90 or 180 degrees
		var move = new Vector2 (Input.GetAxis ("Horizontal"), 0);


			//GetComponent <Rigidbody2D> ().position += move * speed * Time.deltaTime;
	

		if (Input.GetKey (KeyCode.LeftArrow)) {

			transform.forward = new Vector3 (0, 0, -1);

			anim.SetFloat ("move",1);

		}

		else if (Input.GetKey (KeyCode.RightArrow)) {

			transform.forward = new Vector3 (0, 0, 1);

			anim.SetFloat ("move",1);
		}


		 else if (Input.GetKeyUp (KeyCode.LeftArrow) || (Input.GetKeyUp (KeyCode.RightArrow)))
		         {

		        anim.SetFloat ("move",0);
				}

	}
}

