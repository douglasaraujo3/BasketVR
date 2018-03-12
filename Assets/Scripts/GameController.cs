using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public PlayerScript player;
	public float timer = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.holdingBall == false) {
			timer -= Time.deltaTime;
			if (timer <= 0) {
				//Instantiate (ballPrefab);
				SceneManager.LoadScene ("GameScene");
			}
		}
	}
}
