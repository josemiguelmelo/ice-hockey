using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurnBasedGM : MonoBehaviour {

	public GUIText playerText;

	public List<GameObject> players;

	public GameObject playerObject;
    public List<Sprite> playerSprites;

    public int turn = 0;


	// Use this for initialization
	void Start () {

		//left player instances
		players.Add ((GameObject)Instantiate (playerObject, new Vector3 (-12.63f, 3.26f, 0f), Quaternion.identity));
		players.Add ((GameObject)Instantiate (playerObject, new Vector3 (-12.76f, -2.74f, 0f), Quaternion.identity));

        //set red team sprites
		players[0].GetComponent<SpriteRenderer>().sprite = playerSprites[0];
		players[0].GetComponent<SpriteRenderer> ().color = Color.cyan;
        players[0].transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        Destroy(players[0].GetComponent<CircleCollider2D>());
        players[0].AddComponent<CircleCollider2D>();

        players[1].GetComponent<SpriteRenderer>().sprite = playerSprites[1];
		players[1].GetComponent<SpriteRenderer> ().color = Color.cyan;
        players[1].transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        Destroy(players[1].GetComponent<CircleCollider2D>());
        players[1].AddComponent<CircleCollider2D>();

        //right player instances
        players.Add((GameObject)Instantiate (playerObject, new Vector3 (12.63f, 3.26f, 0f), Quaternion.identity));
		players.Add((GameObject)Instantiate (playerObject, new Vector3 (12.63f, -2.74f, 0f), Quaternion.identity));
        //players [2].GetComponent<SpriteRenderer> ().color = Color.blue;
        //players [3].GetComponent<SpriteRenderer> ().color = Color.blue;
        players[2].GetComponent<SpriteRenderer>().sprite = playerSprites[2];
		players[2].transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        Destroy(players[2].GetComponent<CircleCollider2D>());
        players[2].AddComponent<CircleCollider2D>();

        players[3].GetComponent<SpriteRenderer>().sprite = playerSprites[3];
		players[3].transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        Destroy(players[3].GetComponent<CircleCollider2D>());
        players[3].AddComponent<CircleCollider2D>();

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
			playerText.text = "Player 1 turn";
		} 
		else 
		{
			GetComponent<GameController>().addActivePlayer(players[2]);
			GetComponent<GameController>().addActivePlayer(players[3]);
			playerText.text = "Player 2 turn";
		}

		this.resetPlayersSelection ();
	
	}

	public void resetPlayersSelection() {
		foreach (GameObject player in players) {
			player.GetComponent<PlayerMovement> ().selected = false;
		}
	}
		
}
