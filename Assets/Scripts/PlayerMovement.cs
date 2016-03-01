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
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		initialMousePosition = Input.mousePosition;
		initTime = Time.time;
	}

	void OnMouseUp()
	{
		float endTime = Time.time;
		float timeTaken = endTime - initTime;


		Vector3 endPosition = Input.mousePosition;
		float distance = Vector3.Distance (initialMousePosition, endPosition);

		Vector3 differenceVector = ( endPosition - initialMousePosition).normalized;

		movementSpeed = distance / timeTaken;

		GetComponent<Rigidbody2D>().AddForce(
			new Vector2( movementSpeed * differenceVector.x , 
				movementSpeed * differenceVector.y )
		); 
	}

}
