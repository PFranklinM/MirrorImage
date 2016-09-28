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

		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.D) ||
			Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.LeftArrow) ||
			Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.UpArrow) ||
			Input.GetKeyDown (KeyCode.DownArrow)) {

			randomMove = Random.Range (0, 4);

			if (randomMove == 0 && enemyMove.x > 0) {
				enemyMove.x -= 1;
			}

			if (randomMove == 1 && enemyMove.x < 10) {
				enemyMove.x += 1;
			}

			if (randomMove == 2 && enemyMove.y < 10) {
				enemyMove.y += 1;
			}

			if (randomMove == 3 && enemyMove.y > 0) {
				enemyMove.y -= 1;
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
