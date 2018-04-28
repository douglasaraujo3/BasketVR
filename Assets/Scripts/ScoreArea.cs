using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreArea : MonoBehaviour {
	public static int pontuacao = 0;
	public GameObject effectObject;
	public Text textoPontos;
	void Start(){
		effectObject.SetActive (false);
		textoPontos.text = pontuacao.ToString ();
	}

	void OnTriggerEnter(Collider c){
		if (c.GetComponent<BallScript> () != null) {
			pontuacao++;
			effectObject.SetActive (true);
			textoPontos.text = pontuacao.ToString ();
		}
	}


}
