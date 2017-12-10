using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleMoney : MonoBehaviour {
	public Text ShokinUIText;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ShokinUIText.text = "賞金:" + Score.savedMoney.ToString() + "円";	
	}
}
