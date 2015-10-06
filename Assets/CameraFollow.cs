using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.3f;

	private Vector3 velocity = Vector3.zero;

	void Start() {
		transform.position = new Vector3 (target.position.x, target.position.y + 20, target.position.z);
		transform.rotation = Quaternion.AngleAxis(90, Vector3.right);
	}

	void FixedUpdate () {
		if (Time.time > 1) {
			transform.LookAt (target);
			Vector3 targetPosition = new Vector3 (target.position.x, target.position.y + 5, target.position.z - 10);
			transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
		}
	}


}
