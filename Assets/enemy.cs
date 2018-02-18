using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour {
	public GameObject target;
	private NavMeshAgent agent;
	public  GameObject player;
	public  GameObject shinobi;
	public  float dis;
	public int reshot;
	public Transform targets;//追いかける対象-オブジェクトをインスペクタから登録できるように
	public float speed = 0.2f;//移動スピード

	// Use this for initialization

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = target.transform.position;
		Vector3 Apos = player.transform.position;
		Vector3 Bpos = shinobi.transform.position;
		float dis = Vector3.Distance(Apos,Bpos);
		//Debug.Log("Distance : " + dis);
		Vector3 tmp = player.transform.position;
		player.transform.position = new Vector3(tmp.x, tmp.y, tmp.z);
		if (dis < 20) {
			throwing ();
		}
	}

	void throwing(){
	}

}
