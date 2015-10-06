using UnityEngine;
using System.Collections;

public class CollisionWithTerrain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (collision.gameObject.name == "Terrain") {
//			Debug.Log ("hit!");
//		}
	}

	void OnCollisionEnter(Collision collision) {
		Application.LoadLevel(Application.loadedLevel);
	}
}
