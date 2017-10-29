using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throws : MonoBehaviour {
	GameObject ball;
	public Camera camera;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.K)) {
			Shot();
			Debug.Log("打った");
		}
		
	}

	void Shot(){
		int distance = 100;
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
		Ray ray = camera.ScreenPointToRay (center);
		RaycastHit hitInfo;
		if (Physics.Raycast (ray, out hitInfo, distance)) {
			Debug.Log ("あたった");
			if (hitInfo.collider.tag == "enemy") {
				Destroy(hitInfo.collider.gameObject);
				Debug.Log ("消した");
			}
		}
	}
}
