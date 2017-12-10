using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.T)) {
			Score.score = 0;
			Score.Shokin = 0;
			Score.aaaa -= 1;
			SceneManager.LoadScene ("main");
		}

	}
}
