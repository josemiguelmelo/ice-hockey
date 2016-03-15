using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurnBasedGM : MonoBehaviour {

	public GUIText playerText;

	public List<GameObject> players;

	public GameObject playerObject;
	public List<GameObject> activePlayerObjects;

	public GameObject[] getActivePlayerObjects() {
		return activePlayerObjects.ToArray ();
	}
	public int turn = 0;


	// Use this for initialization
	void Start () {

		//left player instances
		players.Add ((GameObject)Instantiate (playerObject, new Vector3 (-12.63f, 3.26f, 0f), Quaternion.identity));
		players.Add ((GameObject)Instantiate (playerObject, new Vector3 (-12.76f, -2.74f, 0f), Quaternion.identity));

		//right player instances
		players.Add((GameObject)Instantiate (playerObject, new Vector3 (12.63f, 3.26f, 0f), Quaternion.identity));
		players.Add((GameObject)Instantiate (playerObject, new Vector3 (12.63f, -2.74f, 0f), Quaternion.identity));
		players [2].GetComponent<SpriteRenderer> ().color = Color.blue;
		players [3].GetComponent<SpriteRenderer> ().color = Color.blue;

		//left player starts playing
		turn = 0;
		playerText.enabled = true;
		GetComponent<GameController>().addActivePlayer(players[0]);
		GetComponent<GameController>().addActivePlayer(players[1]);

		changeTurn ();

	}

	public void changeTurn() {
		turn++;
		GetComponent<GameController>().clearList ();

		if (turn % 2 == 0) 
		{
			GetComponent<GameController>().addActivePlayer(players[0]);
			GetComponent<GameController>().addActivePlayer(players[1]);
			playerText.text = "Red turn";
		} 
		else 
		{
			GetComponent<GameController>().addActivePlayer(players[2]);
			GetComponent<GameController>().addActivePlayer(players[3]);
			playerText.text = "Blue turn";
		}

		this.resetPlayersSelection ();
	
	}

	public void resetPlayersSelection() {
		foreach (GameObject player in players) {
			player.GetComponent<PlayerMovement> ().selected = false;
		}
	}
		
}
