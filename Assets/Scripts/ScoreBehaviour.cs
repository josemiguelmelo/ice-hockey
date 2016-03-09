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
	}

}
