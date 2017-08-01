using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		if(Input.GetKey(KeyCode.S)){
			if (Physics.Raycast (gameObject.transform.position, gameObject.transform.forward, out hit, 1000f)) {
				
				hit.collider.gameObject.transform.DOScale (Vector3.zero,1f);
				hit.collider.gameObject.GetComponent<Collider> ().enabled = false;
				if (hit.collider.gameObject.tag == "green") {
					print ("green cube is shooted");
				} else {
					print ("red cube is shooted");
				}
			}
		}

		
	}
}
