using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goScoreDisplay : MonoBehaviour {

	public GameObject scoreText;

	public int playerScore;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		playerScore = PlayerPrefs.GetInt("Player Score");

		Text playerScoreText = scoreText.GetComponent<Text>();
		playerScoreText.text = "Score: " + playerScore;
	
	}
}
