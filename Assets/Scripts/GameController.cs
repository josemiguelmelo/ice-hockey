using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
	
	public GUIText goalText;

	public List<GameObject> activePlayerObjects;

	public static int gameType;

	public GameObject[] getActivePlayerObjects() {
		return activePlayerObjects.ToArray ();
	}
		
	public void addActivePlayer(GameObject player) {
		this.activePlayerObjects.Add (player);
	}

	public void clearList() {
		this.activePlayerObjects.Clear ();
	}

	// Use this for initialization
	void Start () {
	}

	void Update() {
	}
}
