using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public GameObject ball;
	Vector3 oldVel;

	// Use this for initialization
	void Start () {
		Debug.Log ("ok");
		//ball.AddForce(new Vector2(0,2));

		Debug.Log ("ok");
		ball = GameObject.Find("ball");
		ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(200,100)); 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		oldVel = ball.GetComponent<Rigidbody2D> ().velocity;
	}

	void OnCollisionEnter (Collision c)
	{
		ContactPoint cp = c.contacts [0];

		ball.GetComponent<Rigidbody2D> ().velocity = Vector3.Reflect (oldVel, cp.normal);

		ball.GetComponent<Rigidbody2D> ().velocity = cp.normal * 2.0f;
	}

}
