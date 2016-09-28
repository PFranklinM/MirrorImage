using UnityEngine;
using System.Collections;

public class playerCloneMove : MonoBehaviour {

	public GameObject playerClone;

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

		if(Input.GetKeyDown(KeyCode.LeftArrow) && playerCloneMove.x < 10){
			playerCloneMove.x += 1;
		}

		if(Input.GetKeyDown(KeyCode.D) && playerCloneMove.x > 0){
			playerCloneMove.x -= 1;
		}

		if(Input.GetKeyDown(KeyCode.RightArrow) && playerCloneMove.x > 0){
			playerCloneMove.x -= 1;
		}

		if(Input.GetKeyDown(KeyCode.W) && playerCloneMove.y > 0){
			playerCloneMove.y -= 1;
		}

		if(Input.GetKeyDown(KeyCode.UpArrow) && playerCloneMove.y > 0){
			playerCloneMove.y -= 1;
		}

		if(Input.GetKeyDown(KeyCode.S) && playerCloneMove.y < 10){
			playerCloneMove.y += 1;
		}

		if(Input.GetKeyDown(KeyCode.DownArrow) && playerCloneMove.y < 10){
			playerCloneMove.y += 1;
		}

		playerClone.transform.position = playerCloneMove;

	}
}
