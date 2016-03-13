using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoalScript : MonoBehaviour {
	public GUIText goalText;

	public ScoreBehaviour scoreBehaviour;
	// Use this for initialization
	void Start () {
		goalText.enabled = false;
	}


	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "ball") 
		{
			goalText.enabled = true;

			int team = 0;

			if (this.name == "goal_right") {
				team = 0;
			} else {
				team = 1;
			}


			scoreBehaviour.incScore (team);

			GameObject[] players = GameObject.FindGameObjectsWithTag ("Player");
			GameObject ball = GameObject.FindGameObjectWithTag ("Ball");

			Debug.Log (players.Length);
			foreach (GameObject p in players) //the line the error is pointing to
			{
				p.GetComponent<PlayerMovement>().Reset();
			}

			ball.GetComponent<BallMovement> ().Reset ();


			GameObject go = GameObject.Find ("GameController");
			GameController gameController = go.GetComponent <GameController> ();
			gameController.resetGame ();
		}

	}
}
