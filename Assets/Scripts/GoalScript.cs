using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoalScript : MonoBehaviour {
	public Text goalText;

	// Use this for initialization
	void Start () {
		goalText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "ball") 
		{
			goalText.enabled = true;
		}

	}
}
