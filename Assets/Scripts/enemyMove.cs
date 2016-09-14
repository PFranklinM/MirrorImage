using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour {

	public GameObject enemy;

	private int randomMove;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 enemyMove = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.D) ||
		   Input.GetKeyDown (KeyCode.W)) {

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

		enemy.transform.position = enemyMove;


	
	}
}
