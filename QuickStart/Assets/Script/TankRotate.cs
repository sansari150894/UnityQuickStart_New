using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRotate : MonoBehaviour {

	public int speed = 2;
	void Start () {
		
	}
	

	void Update () {
		
		float x = Input.GetAxis ("Mouse X");
		float finalSpeed = x * speed;
		transform.Rotate (new Vector3(0,finalSpeed,0));
		
	}
}
