using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FreeForAllGM : MonoBehaviour {

	public List<GameObject> players;

	public GameObject playerObject;

	// Use this for initialization
	void Start () {
		//left player instances
		players.Add ((GameObject)Instantiate (playerObject, new Vector3 (-12.63f, 3.26f, 0f), Quaternion.identity));
		players.Add ((GameObject)Instantiate (playerObject, new Vector3 (-12.76f, -2.74f, 0f), Quaternion.identity));
		players.Add((GameObject)Instantiate (playerObject, new Vector3 (12.63f, 3.26f, 0f), Quaternion.identity));
		players.Add((GameObject)Instantiate (playerObject, new Vector3 (12.63f, -2.74f, 0f), Quaternion.identity));

		foreach (GameObject player in players) {
			player.GetComponent<SpriteRenderer> ().color = Color.blue;
			GetComponent<GameController> ().addActivePlayer (player);
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
