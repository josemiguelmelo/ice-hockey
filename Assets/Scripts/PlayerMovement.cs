using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMovement : MonoBehaviour
{

	private Vector3 screenPoint;
	private Vector3 offset;


	private Vector3 initialMousePosition = Vector3.zero;
	private float initTime ;

	private float movementSpeed = 0;

	Vector3 originalPosition;
	Quaternion originalRotation;

	public GUIText goalText;

	// Use this for initialization
	void Start () {
		originalPosition = transform.position;
		originalRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown (0)) {
			initialMousePosition = Input.mousePosition;
			initTime = Time.time;
			goalText.enabled = false;
		}

		else if(Input.GetMouseButtonUp(0)) {
            float endTime = Time.time;
			float timeTaken = endTime - initTime;

			Vector3 endPosition = Input.mousePosition;
			float distance = Vector3.Distance (initialMousePosition, endPosition);

			Vector3 differenceVector = ( endPosition - initialMousePosition).normalized;

            movementSpeed = distance / timeTaken;

            Vector2 forceVec = new Vector2(movementSpeed * differenceVector.x, movementSpeed * differenceVector.y);

            GetComponent<Rigidbody2D>().AddForce(forceVec);
        }
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
