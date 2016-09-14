using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreDisplay : MonoBehaviour {

	public GameObject scoreText;

	public int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		score = GameObject.Find ("Pellet").GetComponent<pelletMove> ().playerScore;

		Text playerScoreText = scoreText.GetComponent<Text>();
		playerScoreText.text = "Score: " + score;
	
	}
}
