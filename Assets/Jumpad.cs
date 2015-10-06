using UnityEngine;
using System.Collections;

public class Jumpad : MonoBehaviour {
	public float thrust = 0.1f;
	private Rigidbody rigid;
	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody>();
	}
	
	
	void OnCollisionEnter(Collision collision) {
		Rigidbody colRigid = collision.gameObject.GetComponent<Rigidbody> ();
		colRigid.AddForce (transform.up * thrust, ForceMode.Impulse);
		
	}
	
}