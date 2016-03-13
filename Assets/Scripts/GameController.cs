using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public GameObject player1_1;
	public GameObject player1_2;
	public GameObject player2_1;
	public GameObject player2_2;

	public int turn;

	public List<GameObject> activePlayerObjects;

	public GameObject[] getActivePlayerObjects() {
		return activePlayerObjects.ToArray ();
	}

	// Use this for initialization
	void Start () {
		turn = 0;
		changeTurn ();
	}

	void Update() {
	}

	public void changeTurn() {
		turn++;
		activePlayerObjects.Clear ();

		if (turn % 2 == 0) {
			activePlayerObjects.Add (player1_1);
			activePlayerObjects.Add (player1_2);
		} else {
			activePlayerObjects.Add (player2_1);
			activePlayerObjects.Add (player2_2);
		}

		player1_1.GetComponent<PlayerMovement>().selected = false;
		player1_2.GetComponent<PlayerMovement>().selected = false;
		player2_1.GetComponent<PlayerMovement>().selected = false;
		player2_2.GetComponent<PlayerMovement>().selected = false;
	}

	public void resetGame() {
		turn = 0;
		changeTurn();
	}

}
