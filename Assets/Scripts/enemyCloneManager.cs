using UnityEngine;
using System.Collections;

public class enemyCloneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		enemyMove enemyMove = GameObject.Find ("Enemy").GetComponent<enemyMove>();
		enemyMove.enemyCommand = false;
	
	}
}
