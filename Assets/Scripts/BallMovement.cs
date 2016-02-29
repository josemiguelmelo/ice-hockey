using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().AddForce(new Vector2(200,100)); 
	}
	

}
