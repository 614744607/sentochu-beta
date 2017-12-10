using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour {
	public GameObject target;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("FPSController");
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject == target){
			SceneManager.LoadScene ("GameOver");
		}
	}
}
