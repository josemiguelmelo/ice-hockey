using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour {

	public int homeScore;
	public int visitorScore;

	public GUIText homeScoreText;
	public GUIText visitScoreText;
    public GameObject winText;
    public GUIText goalText;

	// Use this for initialization
	void Start () {
		homeScore = 0;
		visitorScore = 0;
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
            goalText.enabled = false;
            winText.SetActive(true);
            int winner = 1;
            if (visitorScore == 5)
                winner = 2;
            winText.GetComponent<GUIText>().text = "Player " + winner + " wins!";
            GameController.EndGame();
        }
	}

    

}
