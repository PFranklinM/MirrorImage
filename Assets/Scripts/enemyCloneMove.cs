using UnityEngine;
using System.Collections;

public class enemyCloneMove : MonoBehaviour {

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

		Vector3 enemyPos = new Vector3 (transform.position.x,
			                    transform.position.y,
			                    transform.position.z);

		if (GameObject.Find ("Enemy").GetComponent<enemyMove> ().enemyCommand) {

			randomMove = Random.Range (0, 4);

			if (randomMove == 0 && enemyPos.x > 0) {
				enemyPos.x -= 1;
			}

			if (randomMove == 1 && enemyPos.x < 10) {
				enemyPos.x += 1;
			}

			if (randomMove == 2 && enemyPos.y < 10) {
				enemyPos.y += 1;
			}

			if (randomMove == 3 && enemyPos.y > 0) {
				enemyPos.y -= 1;
			}

		}

		playerX = (int) player.transform.position.x;
		playerY = (int) player.transform.position.y;

		playerCX = (int) playerClone.transform.position.x;
		playerCY = (int) playerClone.transform.position.y;

		if (enemyPos.x == playerX && enemyPos.y == playerY) {
			//			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}

		if (enemyPos.x == playerCX && enemyPos.y == playerCY) {
			//			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}

		enemy.transform.position = enemyPos;
	}
}
