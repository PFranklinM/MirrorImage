using UnityEngine;
using System.Collections;

public class gameBoard : MonoBehaviour {

	public Vector3 gridSize;

	GameObject[][] board;



	// Use this for initialization
	void Start () {

		Vector3 moving = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		gridSize = new Vector3(11, 11);

		board = new GameObject[(int)gridSize.x][];

		for (int x = 0; x < gridSize.x; x++) {
			
			board [x] = new GameObject[(int)gridSize.y];

			for (int y = 0; y < gridSize.y; y++) {
				
				GameObject tiles = GameObject.CreatePrimitive (PrimitiveType.Cube);

				moving.x = x * 1f;

				moving.y = y * 1f;

				board [x][y] = tiles;

				if ((x + y) % 2 == 0) {
					tiles.GetComponent<Renderer> ().material.color = new Color (5.5f, 5.5f, 5.5f);
				} else {
					tiles.GetComponent<Renderer> ().material.color = new Color (0f, 0f, 0f);
				}

				tiles.transform.position = moving;

			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
