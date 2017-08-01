using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenrate : MonoBehaviour {

	public GameObject Cube;
	void Start () {
		InvokeRepeating ("CubeInstantiate",1f,1f);
	}
	

	void Update () {
		
	}

	void CubeInstantiate(){
		float x = Random.Range (-30f, 30f);
		float y = Random.Range (30f,50f);
		GameObject g= Instantiate(Cube,new Vector3(x,y,50f),Random.rotation) as GameObject;
		print (g.tag);
		Destroy (g,5f);
	}
}
