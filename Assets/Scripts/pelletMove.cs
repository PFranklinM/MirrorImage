using UnityEngine;
using System.Collections;

public class pelletMove : MonoBehaviour {

	public GameObject pellet;

	public GameObject player;
	public GameObject playerClone;

	public GameObject enemy1;

	private int playerX;
	private int playerY;

	private int playerCloneX;
	private int playerCloneY;

	bool enemyWasSpawnedA = false;
	bool enemyWasSpawnedB = false;
	bool enemyWasSpawnedC = false;
	bool enemyWasSpawnedD = false;

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

			playerScore += 100;
		}

		if (pelletMove.x == playerCloneX && pelletMove.y == playerCloneY) {
			pelletMove.x = Random.Range (0, 11);
			pelletMove.y = Random.Range (0, 11);

			playerScore += 100;
		}

		if (playerScore >= 600 && enemyWasSpawnedA == false) {

			GameObject enemy2 = (GameObject)Instantiate (Resources.Load ("EnemyClone"));

			Vector3 enemy2Move = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			enemy2Move.x = 0;
			enemy2Move.y = 0;

			enemy2.transform.position = enemy2Move;

			enemyWasSpawnedA = true;
		}

		if (playerScore >= 1100 && enemyWasSpawnedB == false) {
			
			GameObject enemy3 = (GameObject)Instantiate (Resources.Load ("EnemyClone"));

			Vector3 enemy3Move = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			enemy3Move.x = 10;
			enemy3Move.y = 10;

			enemy3.transform.position = enemy3Move;

			enemyWasSpawnedB = true;
			
		}

		if (playerScore >= 1600 && enemyWasSpawnedC == false) {
			
			GameObject enemy4 = (GameObject)Instantiate (Resources.Load ("EnemyClone"));

			Vector3 enemy4Move = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			enemy4Move.x = 10;
			enemy4Move.y = 0;

			enemy4.transform.position = enemy4Move;

			enemyWasSpawnedC = true;
			
		}

		if (playerScore >= 2100 && enemyWasSpawnedD == false) {

			GameObject enemy5 = (GameObject)Instantiate (Resources.Load ("EnemyClone"));

			Vector3 enemy5Move = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			enemy5Move.x = 5;
			enemy5Move.y = 5;

			enemy5.transform.position = enemy5Move;

			enemyWasSpawnedD = true;
			
		}

		PlayerPrefs.SetInt("Player Score", playerScore);

		pellet.transform.position = pelletMove;
	
	}
}
