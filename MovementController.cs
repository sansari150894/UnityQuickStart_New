using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class MovementController : MonoBehaviour {
	public static MovementController Instance;

	public float speed = 3.0F;
    public float rotateSpeed = 2.0F;

	public bool moveForward;
	//chanrctercontroller script
	private CharacterController controllor;
	// GvrViewer Script
	private GvrViewer gurViewer;
    // VR Head
    public static float curSpeed;

    private Transform vrHead;

	void Start(){
		Instance = this;

		controllor = GetComponent<CharacterController>();
		gurViewer = transform.GetChild (0).GetComponent<GvrViewer> ();
		vrHead = Camera.main.transform;
 	}

	void Update() {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
		Vector3 forward = vrHead.TransformDirection(Vector3.forward);
		 curSpeed = speed * Input.GetAxis("Vertical");

		controllor.SimpleMove(forward * curSpeed);
	}
}