using UnityEngine;
using System.Collections;

public class BackgroundParallax : MonoBehaviour 
{
	public Transform[] backgrounds;            //  Array of all the backgrounds to be parallaxed
	public float parallaxScale;                //  The proportion of the camera's movement to move the backgrounds by
	public float parallaxReductionFactor;        //  How much less each succesive layer should parallax     
	public float parallax;
	
	void Update () 
	{
		parallax = 0;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			parallax = (-1) * parallaxScale;
		}
		
		
		else if (Input.GetKey (KeyCode.RightArrow)) {
			parallax = (1) * parallaxScale;			
			
		}
		
		for (int i = 0; i < backgrounds.Length; i++)                               // for each success background...
		{                                                                          
			backgrounds[i].GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", new Vector2(backgrounds[i].GetComponent<MeshRenderer>().material.mainTextureOffset.x + parallax / 1000, backgrounds[i].GetComponent<MeshRenderer>().material.mainTextureOffset.y));
		}
	}
}