using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class hit : MonoBehaviour {
	public GameObject target;
	private NavMeshAgent agent;
	public  GameObject player;
	public  GameObject shinobi;
	public  float dis;
	public int reshot;
	float times;


	// Use this for initialization
	void Start () {
		times = 0;
		agent = GetComponent<NavMeshAgent>() ;
		target = GameObject.Find("FPSController");
		//this.GetComponent<Rigidbody>().AddForce(ja);
		Rigidbody enemyShellRb = this.GetComponent<Rigidbody>();
		// forwardはZ軸方向（青軸方向）、この方向に力を加える。
		this.transform.parent = this.transform;
		enemyShellRb.AddForce(transform.forward *10);
		Destroy(this.gameObject, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
//		times += Time.deltaTime;
//		if(times>5.0f){
//			Destroy(this.gameObject);
//		}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject == target){
			SceneManager.LoadScene ("GameOver");
		}
	}
}
