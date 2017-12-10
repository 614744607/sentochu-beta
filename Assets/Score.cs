using UnityEngine;
using System.Collections;
using UnityEngine.UI;//この宣言が必要

public class Score : MonoBehaviour {
	// 時間を表示するUIText
	public Text scoreUIText;
	// 合計時間を表示するUIText
	public static Text ShokinText;
	//public Text ItemText;
	public Text highScoreUIText;
	public Text ShokinPerSecUIText;
	public Text ItemNumberText;
	// 時間
	public static float score = 0;
	// 合計時間

	public static float Shokin = 0;
	public static float savedMoney;
	public static float ShokinPerSec = 100;
	public static float highScore = 0;
	public static int Shokin2;
	// PlayerPrefsで保存するためのキー


	// Use this for initialization
	void Start () { //保存されたデータを読み込む
		savedMoney = PlayerPrefs.GetFloat("inta");
	}
	
	// Update is called once per frame
	void Update () {
		ShokinText.text = "賞金：" + savedMoney.ToString() + "円";




	}

		public void Save (){
			// ハイスコアを保存する

			//	Initialize ();
		} 
}