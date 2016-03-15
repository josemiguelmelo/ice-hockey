using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	Vector3 originalPosition;
	Quaternion originalRotation;

	// Use this for initialization
	void Start () {
		originalPosition = transform.position;
		originalRotation = transform.rotation;
	}

	public void Reset() {
		transform.position = originalPosition;
		transform.rotation = originalRotation;
		if (GetComponent<Rigidbody2D>() != null) {
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			GetComponent<Rigidbody2D>().angularVelocity = 0;
		}
	}
	

}
