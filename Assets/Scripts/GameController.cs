using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	
	public GUIText goalText;
	public List<GameObject> activePlayerObjects;
	public static int gameType;

    public static GameController instance;

    public GameObject[] getActivePlayerObjects() {
		return activePlayerObjects.ToArray ();
	}
		
	public void addActivePlayer(GameObject player) {
		this.activePlayerObjects.Add (player);
	}

	public void clearList() {
		this.activePlayerObjects.Clear ();
	}

    public static void EndGame()
    {
        if(instance)
            instance.Invoke("LoadMainScene", 2.0f);
    }

    void LoadMainScene()
    {
        //Load the selected scene, by scene index number in build settings
        SceneManager.LoadScene(0);
    }

	// Use this for initialization
	void Start () {
        instance = this;

		if(gameType == 1) {
			this.GetComponent<TurnBasedGM> ().enabled = true;
		} 
		else 
		{
			this.GetComponent<FreeForAllGM> ().enabled = true;
		}
	}

	void Update() {
	}
}
