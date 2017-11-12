using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class throws : MonoBehaviour {
	GameObject ball;
	public Camera camera;
	public GameObject enemy;
	public static GameObject objA;
	public static GameObject objB;
	public static float dis;
	public static int reshot;

	// Use this for initialization
	void Start () {
		reshot = 1;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.K)) {
			Shot();
			Debug.Log("打った");
		}
		Vector3 Apos = objA.transform.position;
		Vector3 Bpos = objB.transform.position;
		float s = Vector3.Distance(Apos,Bpos);
		Debug.Log("Distance : " + dis);

		if (dis < 20) {
			throwing ();
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
				hitInfo.collider.gameObject.SetActive (false);
				Debug.Log ("消した");
			SceneManager.LoadScene ("GameClear");

			}
		}


	}
	void throwing(){
		reshot = 0;	
	}
}
