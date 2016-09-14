using UnityEngine;
using System.Collections;

public class playerCloneMove : MonoBehaviour {

	public GameObject playerClone;

	public GameObject enemy1;
	public GameObject enemy2;

	private int enemy1X;
	private int enemy1Y;

	private int enemy2X;
	private int enemy2Y;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		Vector3 playerCloneMove = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if(Input.GetKeyDown(KeyCode.A) && playerCloneMove.x < 10){
			playerCloneMove.x += 1;
		}

		if(Input.GetKeyDown(KeyCode.D) && playerCloneMove.x > 0){
			playerCloneMove.x -= 1;
		}

		if(Input.GetKeyDown(KeyCode.W) && playerCloneMove.y > 0){
			playerCloneMove.y -= 1;
		}

		if(Input.GetKeyDown(KeyCode.S) && playerCloneMove.y < 10){
			playerCloneMove.y += 1;
		}

		enemy1X = (int) enemy1.transform.position.x;
		enemy1Y = (int) enemy1.transform.position.y;

		enemy2X = (int) enemy2.transform.position.x;
		enemy2Y = (int) enemy2.transform.position.y;

		if (playerCloneMove.x == enemy1X && playerCloneMove.y == enemy1Y) {
//			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}

		if (playerCloneMove.x == enemy2X && playerCloneMove.y == enemy2Y) {
//			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}

		playerClone.transform.position = playerCloneMove;

	}
}
