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

	public bool selected;

	// Use this for initialization
	void Start () {
		originalPosition = transform.position;
		originalRotation = transform.rotation;

		selected = false;
	}


	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown (0)) {
			initialMousePosition = Input.mousePosition;
			initTime = Time.time;
			goalText.enabled = false;

			GameObject nearestObject = null;
			GameObject[] objects = GameObject.FindGameObjectsWithTag ("Player");
            Debug.Log(objects.Length);
			foreach (GameObject o in objects) {
                Debug.Log(o.ToString());
				o.GetComponent<PlayerMovement>().selected = false;
				if (nearestObject == null) {
					nearestObject = o;
				} else {
					if (Vector3.Distance (o.transform.localPosition, Camera.main.ScreenToWorldPoint(initialMousePosition)) <=
						Vector3.Distance (nearestObject.transform.position, Camera.main.ScreenToWorldPoint(initialMousePosition))) {
						nearestObject = o;
					}
				}
			}

			nearestObject.GetComponent<PlayerMovement> ().selected = true;
		}

		else if(Input.GetMouseButtonUp(0)) {

			if (selected) {
				float endTime = Time.time;
				float timeTaken = endTime - initTime;

				Vector3 endPosition = Input.mousePosition;
				float distance = Vector3.Distance (initialMousePosition, endPosition);

				Vector3 differenceVector = (endPosition - initialMousePosition).normalized;

				movementSpeed = distance / timeTaken;

				Vector2 forceVec = new Vector2 (movementSpeed * differenceVector.x, movementSpeed * differenceVector.y);

				GetComponent<Rigidbody2D> ().AddForce (forceVec);
			}
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
