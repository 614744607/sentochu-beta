using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Runningtime : MonoBehaviour {
	public Camera camera;

	public Text timeUIText;
//	public int Mission1 = 0;
	public Text itemText;
	public Text EText;
	public Text PText;


	public static int energyDrink;

	// Use this for initialization
	public float runTime;
	public float Shokincheck;
	public float dushtime;
	public GameObject enemyObjects;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//enemyObjects = GameObject.FindGameObjectsWithTag ("Hnunter");
		//enemyNum = enemyObjects.Length;

	

		Score.score = Time.deltaTime + Score.score;
		float appearScore = 300 - Score.score;

		timeUIText.text = "残り時間 : " + appearScore.ToString ("F0") + "秒"; //表示して
//		PText.text="";


		if (Score.score >= 300) {
			Score.score = 0;
			SceneManager.LoadScene ("GameOver");

		}






		if (Input.GetKey (KeyCode.Q)) {
			Score.score = 290;
		}	
		if (Input.GetKey (KeyCode.E)) {
			Score.score = 240;
		}	
		if (Input.GetKeyDown(KeyCode.X)) {
			Score.score += 50;
		}	



			
		}

}