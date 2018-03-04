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
	public float speed;
	public Vector3 force;
	Rigidbody rigidbodyw;
	public GameObject sphere;
	GameObject tas;
	public static int numbers;
	public static int balls;

	// Use this for initialization
	void Start () {
		reshot = 1;
		balls = 10;
		rigidbodyw = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K)) {
			if (balls > 0) {
				balls -= 1;
				Shot ();
				Debug.Log ("打った");
			}
		}
		Check("enemy");

	}


	void Check(string tagname){
		tagObjects = GameObject.FindGameObjectsWithTag(tagname);
		numbers = tagObjects.Length;
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
		Instantiate (sphere ,this.transform.position, this.transform.rotation);
	}
}
