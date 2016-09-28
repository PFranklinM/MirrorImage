using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public GameObject player;

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

		if(Input.GetKeyDown(KeyCode.LeftArrow) && playerMove.x > 0){
			playerMove.x -= 1;
		}

		if(Input.GetKeyDown(KeyCode.D) && playerMove.x < 10){
			playerMove.x += 1;
		}

		if(Input.GetKeyDown(KeyCode.RightArrow) && playerMove.x < 10){
			playerMove.x += 1;
		}

		if(Input.GetKeyDown(KeyCode.W) && playerMove.y < 10){
			playerMove.y += 1;
		}

		if(Input.GetKeyDown(KeyCode.UpArrow) && playerMove.y < 10){
			playerMove.y += 1;
		}

		if(Input.GetKeyDown(KeyCode.S) && playerMove.y > 0){
			playerMove.y -= 1;
		}

		if(Input.GetKeyDown(KeyCode.DownArrow) && playerMove.y > 0){
			playerMove.y -= 1;
		}

		player.transform.position = playerMove;
	
	}
}
