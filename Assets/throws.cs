using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class throws : MonoBehaviour {
	GameObject ball;
	public Camera camera;
	public GameObject enemy;
	public static GameObject player;
	public static GameObject shinobi;
	public static float dis;
	public static int reshot;
	public GameObject[] tagObjects;
	public int numberhunter;
	public int playershell;
	public float shotSpeed;
	public GameObject playershellPrefab;
	public Text ShokinUIText;

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
		Check("enemy");

	}

	void Check(string tagname){
		tagObjects = GameObject.FindGameObjectsWithTag(tagname);
		Debug.Log(tagObjects.Length); //tagObjects.Lengthはオブジェクトの数
		if(tagObjects.Length == 0){
			Score.savedMoney = Score.savedMoney + Score.Shokin;
			Score.Shokin = 0;
			SceneManager.LoadScene ("GameClear");
		}

		if (Input.GetKeyDown(KeyCode.M)) {
			Score.savedMoney += 200000;
			Score.Shokin = 0;
			SceneManager.LoadScene ("GameClear");
		}	
	}
		


	void Shot(){

		int distance = 100;
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);

		/*GameObject playershell = (GameObject)Instantiate(playershellPrefab, transform.position, Quaternion.identity);
		Rigidbody playershellRb = playershell.GetComponent<Rigidbody>();
		// forwardはZ軸方向（青軸方向）、この方向に力を加える。
		playershellRb.AddForce(transform.forward *  50);
		Destroy(playershell, 5.0f);*/

		Ray ray = camera.ScreenPointToRay (center);
		RaycastHit hitInfo;
		if (Physics.Raycast (ray, out hitInfo, distance)) {
			Debug.Log ("あたった");
			if (hitInfo.collider.tag == "enemy") {
				Destroy (hitInfo.collider.gameObject);
				//hitInfo.collider.gameObject.SetActive (false);
				Debug.Log ("消した");
				Score.Shokin = Score.Shokin + 100000;
				ShokinUIText.text = "賞金:" + Score.Shokin + "円";
			}


		}
	}
}
