using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour {

	public int homeScore;
	public int visitorScore;


	public GUIText homeScoreText;
	public GUIText visitScoreText;

	// Use this for initialization
	void Start () {
		homeScore = 5;
		visitorScore = 5;
	}


	public void incScore(int team)
	{
		if (team == 0) {
			homeScore++;
		} else {
			visitorScore++;
		}

		homeScoreText.text = homeScore.ToString();
		visitScoreText.text = visitorScore.ToString();

        Debug.Log("Home Score: " + homeScore);
        Debug.Log("Visitor Score: " + visitorScore);

        if (homeScore == 5 || visitorScore == 5)
        {
            Debug.Log("Acabou o jogo");
            GameController.EndGame();
        }
	}

}
