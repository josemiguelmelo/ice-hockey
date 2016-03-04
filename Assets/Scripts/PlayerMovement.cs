using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;


	private Vector3 initialMousePosition = Vector3.zero;
	private float initTime ;

	private float movementSpeed = 0;

	// Use this for initialization
	void Start () {
		Debug.Log ("melo foi criado");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			initialMousePosition = Input.mousePosition;
			initTime = Time.time;
		}

		if(Input.GetMouseButtonUp(0)) {

			float endTime = Time.time;
			float timeTaken = endTime - initTime;

			Vector3 endPosition = Input.mousePosition;
			float distance = Vector3.Distance (initialMousePosition, endPosition);

			Vector3 differenceVector = ( endPosition - initialMousePosition).normalized;

			GameObject player = GameObject.Find ("player_1");
			Rigidbody2D playerBody = player.GetComponent<Rigidbody2D> ();

			movementSpeed = distance / timeTaken;

			playerBody.AddForce(
				new Vector2( movementSpeed * differenceVector.x , 
					movementSpeed * differenceVector.y )
			); 
		}
	}

	void OnMouseDown()
	{
		Debug.Log ("melo clickou");
	}

	void OnMouseUp()
	{
		Debug.Log ("melo largou");
	}

}
