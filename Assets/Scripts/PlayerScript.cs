using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public BallScript ball;
	public GameObject playerGamera;
	public float ballDistance;
	public float ballForce;



	public bool holdingBall = true;

	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody> ().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (holdingBall) {
			ball.transform.position = playerGamera.transform.position + playerGamera.transform.forward * ballDistance;
			if(Input.GetMouseButtonDown(0)){
				holdingBall = false;
				ball.ActivateTrail ();
				ball.GetComponent<Rigidbody> ().useGravity = true;
				ball.GetComponent<Rigidbody>().AddForce (playerGamera.transform.forward * ballForce);
			}
		}
	}
	public void shootBall(){
		holdingBall = false;
		ball.ActivateTrail ();
		ball.GetComponent<Rigidbody> ().useGravity = true;
		ball.GetComponent<Rigidbody>().AddForce (playerGamera.transform.forward * ballForce);
	}
}
