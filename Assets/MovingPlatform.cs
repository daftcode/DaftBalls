using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {
	public float speed = 1.5f;
	public Vector3 endPoint;
	
	private Vector3 startPoint;
	private Vector3 targetPoint;
	private Rigidbody rigid;
	
	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody>();
		startPoint = rigid.position;
		targetPoint = endPoint;
	}
	
	void FixedUpdate () {
		float step = speed * Time.deltaTime;
		Vector3 moveDelta = Vector3.MoveTowards (transform.position, targetPoint, step);
		if (moveDelta == targetPoint) {
			if(targetPoint == endPoint){
				targetPoint = startPoint;
			}  else if(targetPoint == startPoint){
				targetPoint = endPoint;
			}
		}
		rigid.MovePosition(moveDelta);
	}
}