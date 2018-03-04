using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nageru : MonoBehaviour {

	Rigidbody rigidbody2;
	public float sandl;

	// Use this for initialization
	void Start () {
		rigidbody2 = GetComponent<Rigidbody>();
		rigidbody2.AddForce (transform.forward * 1000);
	}

	void OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag);
		if (collision.gameObject.tag == "enemy") {
			Destroy(collision.gameObject);
			Score.Shokin = Score.Shokin + 100000;
		}

		if (sandl > 1) {
			if (collision.gameObject.tag == "Player") {
				Debug.Log ("ボール");
				throws.balls += 1;
				Destroy (this.gameObject);
			}
		}
	}

	
	// Update is called once per frame
	void Update () {
		sandl = sandl + Time.deltaTime;
	}
}
