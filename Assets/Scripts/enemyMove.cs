using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour {

	public GameObject enemy;

	public GameObject player;
	public GameObject playerClone;

	private int playerX;
	private int playerY;

	private int playerCX;
	private int playerCY;

	private int randomMove;

	public bool enemyDidMove = true;

	public bool enemyCommand = false;

	private float enemyDelay = 0;

	// Use this for initialization
	void Start () {

		player = GameObject.Find("Player");
		playerClone = GameObject.Find("PlayerClone");
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 enemyMove = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if (GameObject.Find ("Player").GetComponent<playerMove> ().playerDidMove) {

			enemyDelay += Time.deltaTime;

//			randomMove = Random.Range (0, 4);

			randomMove = Random.Range (0, 6);

			if (enemyDelay >= 0.5f) {

				if (randomMove == 0 && enemyMove.x > 0) {
					enemyMove.x -= 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;
					
					enemyDelay = 0f;
				}

				if (randomMove == 1 && enemyMove.x < 10) {
					enemyMove.x += 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}

				if (randomMove == 2 && enemyMove.y < 10) {
					enemyMove.y += 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}

				if (randomMove == 3 && enemyMove.y > 0) {
					enemyMove.y -= 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}



				//Enemy Seek 1

				if (randomMove == 4 && player.transform.position.x > enemyMove.x) {
					enemyMove.x += 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}

				if (randomMove == 4 && player.transform.position.x < enemyMove.x) {
					enemyMove.x -= 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}

				if (randomMove == 4 && player.transform.position.x == enemyMove.x &&
					player.transform.position.y > enemyMove.y) {
					enemyMove.y += 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}

				if (randomMove == 4 && player.transform.position.x == enemyMove.x &&
					player.transform.position.y < enemyMove.y) {
					enemyMove.y -= 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}



				//Enemy Seek 2

				if (randomMove == 5 && player.transform.position.y > enemyMove.y) {
					enemyMove.y += 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}

				if (randomMove == 5 && player.transform.position.y < enemyMove.y) {
					enemyMove.y -= 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}

				if (randomMove == 5 && player.transform.position.y == enemyMove.y &&
					player.transform.position.x > enemyMove.x) {
					enemyMove.x += 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}

				if (randomMove == 5 && player.transform.position.y == enemyMove.y &&
					player.transform.position.x < enemyMove.x) {
					enemyMove.x -= 1;
					enemyDidMove = true;
					playerMove playerMove = GameObject.Find ("Player").GetComponent<playerMove> ();
					playerMove.playerDidMove = false;

					enemyCommand = true;

					enemyDelay = 0f;
				}
			}
		}

		playerX = (int) player.transform.position.x;
		playerY = (int) player.transform.position.y;

		playerCX = (int) playerClone.transform.position.x;
		playerCY = (int) playerClone.transform.position.y;

		if (enemyMove.x == playerX && enemyMove.y == playerY) {
			//			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}

		if (enemyMove.x == playerCX && enemyMove.y == playerCY) {
			//			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}

		enemy.transform.position = enemyMove;


	
	}
}
