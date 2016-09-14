using UnityEngine;
using System.Collections;

public class pelletMove : MonoBehaviour {

	public GameObject pellet;

	public GameObject player;
	public GameObject playerClone;

	private int playerX;
	private int playerY;

	private int playerCloneX;
	private int playerCloneY;

	public int playerScore = 0;

	// Use this for initialization
	void Start () {

		Vector3 pelletMove = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		pelletMove.x = Random.Range (0, 11);
		pelletMove.y = Random.Range (0, 11);

		pellet.transform.position = pelletMove;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pelletMove = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		playerX = (int) player.transform.position.x;
		playerY = (int) player.transform.position.y;

		playerCloneX = (int) playerClone.transform.position.x;
		playerCloneY = (int) playerClone.transform.position.y;

		if (pelletMove.x == playerX && pelletMove.y == playerY) {
			pelletMove.x = Random.Range (0, 11);
			pelletMove.y = Random.Range (0, 11);

			playerScore += 1;
		}

		if (pelletMove.x == playerCloneX && pelletMove.y == playerCloneY) {
			pelletMove.x = Random.Range (0, 11);
			pelletMove.y = Random.Range (0, 11);

			playerScore += 1;
		}

		PlayerPrefs.SetInt("Player Score", playerScore);

		pellet.transform.position = pelletMove;

//		Debug.Log (playerScore);
	
	}
}
