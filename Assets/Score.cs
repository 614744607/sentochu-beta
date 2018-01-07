using UnityEngine;
using System.Collections;
using UnityEngine.UI;//この宣言が必要

public class Score : MonoBehaviour {
	// 時間を表示するUIText
	public Text ScoreUIText;
	// 合計時間を表示するUIText

	// 時間
	public static float score = 0;
	// 合計時間

	public static float Shokin = 0;
	public static float savedMoney;
	public static float highScore = 0;
	public static float inta;
	public static int Shokin2;
	public static int aaaa = 0;
	// PlayerPrefsで保存するためのキー


	// Use this for initialization
	void Start () { //保存されたデータを読み込む

	}

	void OnSceneLoaded (){
		savedMoney = PlayerPrefs.GetFloat("inta"); 
	}
	
	// Update is called once per frame
	void Update () {
		ScoreUIText.text = "賞金：" + savedMoney.ToString() + "円";
	}

		public void Save (){
		
		} 
}