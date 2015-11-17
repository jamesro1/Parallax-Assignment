using UnityEngine;
using System.Collections;

public class ObjectBgParallax : MonoBehaviour 
{
	public Transform[] backgrounds;            //  Array of all the backgrounds to be parallaxed
	public float parallaxScale;                //  The proportion of the camera's movement to move the backgrounds by
	public float parallaxReductionFactor;        //  How much less each succesive layer should parallax     
	public float parallax;


	void Update () 
	{
		parallax = 0;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			parallax = (1) * parallaxScale;
		}
		
		
		else if (Input.GetKey (KeyCode.RightArrow)) {
			parallax = (-1) * parallaxScale;			
			
		}
		
		for (int i = 0; i < backgrounds.Length; i++)                               // for each success background...
		{                                                                          
			backgrounds[i].transform.position = new Vector3 (backgrounds[i].transform.position.x + parallax * parallaxReductionFactor, backgrounds[i].transform.position.y, backgrounds[i].transform.position.z);    
		}
	}
}
