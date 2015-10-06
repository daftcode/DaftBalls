using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {
	public float speed = 1.0f;
	private Rigidbody rigid;
	public float startY = -0.25f;
	public float endY = 2.0f;
	private int moveDirection = 1;
	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//	transform.position.y += speed * Time.deltaTime;
		if (transform.position.y > endY) {
			moveDirection = -1;
		} else if (transform.position.y < startY) {
			moveDirection = 1;
		}
		rigid.MovePosition(transform.position + transform.up * moveDirection * speed* Time.deltaTime);
		
	}
}