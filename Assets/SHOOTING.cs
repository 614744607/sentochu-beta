using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SHOOTING : MonoBehaviour {

	public GameObject enemyShellPrefab;
	public float shotSpeed;
	public AudioClip shotSound;
	private float shotIntarval;
	private Transform target;
	private NavMeshAgent agent;
	public int numberhunter;


	void Start(){
		GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();       

	}

	void Update () {

		shotIntarval += 1;

		if(shotIntarval % 22 == 0){
			GameObject enemyShell = (GameObject)Instantiate(enemyShellPrefab, transform.position, Quaternion.identity);
			Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();
			// forwardはZ軸方向（青軸方向）、この方向に力を加える。
			enemyShellRb.AddForce(transform.forward * shotSpeed);
			AudioSource.PlayClipAtPoint(shotSound, transform.position);
			Destroy(enemyShell, 5.0f);


		}
	}
}