using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public GameObject player;

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

		Vector3 playerMove = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if(Input.GetKeyDown(KeyCode.A) && playerMove.x > 0){
			playerMove.x -= 1;
		}

		if(Input.GetKeyDown(KeyCode.D) && playerMove.x < 10){
			playerMove.x += 1;
		}

		if(Input.GetKeyDown(KeyCode.W) && playerMove.y < 10){
			playerMove.y += 1;
		}

		if(Input.GetKeyDown(KeyCode.S) && playerMove.y > 0){
			playerMove.y -= 1;
		}

		enemy1X = (int) enemy1.transform.position.x;
		enemy1Y = (int) enemy1.transform.position.y;

		enemy2X = (int) enemy2.transform.position.x;
		enemy2Y = (int) enemy2.transform.position.y;

		if (playerMove.x == enemy1X && playerMove.y == enemy1Y) {
//			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}

		if (playerMove.x == enemy2X && playerMove.y == enemy2Y) {
//			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}

		player.transform.position = playerMove;
	
	}
}
