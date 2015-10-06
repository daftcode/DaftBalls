using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public int speed = 20;

	private Rigidbody rb;

	// directions
	private Vector3 forward = Vector3.forward;
	private Vector3 backward = -Vector3.forward;
	private Vector3 right = Vector3.right;
	private Vector3 left = -Vector3.right;

	void Start () {
		rb = gameObject.GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		if (Time.time > 1) {
			if (Input.GetKey ("up"))
				Move (forward);
			if (Input.GetKey ("down"))
				Move (backward);
			if (Input.GetKey ("right"))
				Move (right);
			if (Input.GetKey ("left"))
				Move (left);
			if (Input.GetKeyDown ("space"))
				rb.AddForce(Vector2.up * speed * 50);
		}
	}
	
	void Move(Vector3 direction) {
		rb.AddForce(direction * speed);
	}
}