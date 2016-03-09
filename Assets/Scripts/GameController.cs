using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject player1_1;
	public GameObject player1_2;
	public GameObject player2_1;
	public GameObject player2_2;

	public int turn;

	// Use this for initialization
	void Start () {
		turn = 1;
		player1_1.GetComponent<PlayerMovement> ().enabled = false;
		player1_2.GetComponent<PlayerMovement> ().enabled = false;
		player2_1.GetComponent<PlayerMovement> ().enabled = true;
		player2_2.GetComponent<PlayerMovement> ().enabled = true;

	}

	void Update() {
		if(Input.GetMouseButtonUp(0)) {
			if (turn == 1) {
				turn = 2;
				player1_1.GetComponent<PlayerMovement> ().enabled = true;
				player1_2.GetComponent<PlayerMovement> ().enabled = true;
				player2_1.GetComponent<PlayerMovement> ().enabled = false;
				player2_2.GetComponent<PlayerMovement> ().enabled = false;

			} else {
				turn = 1;
				player1_1.GetComponent<PlayerMovement> ().enabled = false;
				player1_2.GetComponent<PlayerMovement> ().enabled = false;
				player2_1.GetComponent<PlayerMovement> ().enabled = true;
				player2_2.GetComponent<PlayerMovement> ().enabled = true;
			}
		}
	}

}
