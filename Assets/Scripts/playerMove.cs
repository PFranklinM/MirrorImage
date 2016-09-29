using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public GameObject player;
	public GameObject playerClone;

	public bool playerDidMove = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 playerMove = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

		Vector3 playerCloneMove = new Vector3 (playerClone.transform.position.x,
			playerClone.transform.position.y,
			playerClone.transform.position.z);

		if (GameObject.Find ("Enemy").GetComponent<enemyMove>().enemyDidMove) {

			if (Input.GetKeyDown (KeyCode.A) && playerMove.x > 0) {
				playerMove.x -= 1;
				playerCloneMove.x += 1;

				playerDidMove = true;
				enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
				enemyMove.enemyDidMove = false;
			}

			if (Input.GetKeyDown (KeyCode.LeftArrow) && playerMove.x > 0) {
				playerMove.x -= 1;
				playerCloneMove.x += 1;

				playerDidMove = true;
				enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
				enemyMove.enemyDidMove = false;
			}

			if (Input.GetKeyDown (KeyCode.D) && playerMove.x < 10) {
				playerMove.x += 1;
				playerCloneMove.x -= 1;

				playerDidMove = true;
				enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
				enemyMove.enemyDidMove = false;
			}

			if (Input.GetKeyDown (KeyCode.RightArrow) && playerMove.x < 10) {
				playerMove.x += 1;
				playerCloneMove.x -= 1;

				playerDidMove = true;
				enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
				enemyMove.enemyDidMove = false;
			}

			if (Input.GetKeyDown (KeyCode.W) && playerMove.y < 10) {
				playerMove.y += 1;
				playerCloneMove.y -= 1;

				playerDidMove = true;
				enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
				enemyMove.enemyDidMove = false;
			}

			if (Input.GetKeyDown (KeyCode.UpArrow) && playerMove.y < 10) {
				playerMove.y += 1;
				playerCloneMove.y -= 1;

				playerDidMove = true;
				enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
				enemyMove.enemyDidMove = false;
			}

			if (Input.GetKeyDown (KeyCode.S) && playerMove.y > 0) {
				playerMove.y -= 1;
				playerCloneMove.y += 1;

				playerDidMove = true;
				enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
				enemyMove.enemyDidMove = false;
			}

			if (Input.GetKeyDown (KeyCode.DownArrow) && playerMove.y > 0) {
				playerMove.y -= 1;
				playerCloneMove.y += 1;

				playerDidMove = true;
				enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
				enemyMove.enemyDidMove = false;
			}
		}

		player.transform.position = playerMove;
		playerClone.transform.position = playerCloneMove;
	
	}
}
