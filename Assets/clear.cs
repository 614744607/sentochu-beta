﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.T)) {
			Score.score = 0;
			SceneManager.LoadScene ("GameClear");
			Debug.Log ("保存したよ");
			SceneManager.LoadScene("main");
		}
	}
}
