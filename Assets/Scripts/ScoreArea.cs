using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {
	
	public GameObject effectObject;
	void Start(){
		effectObject.SetActive (false);

	}

	void OnTriggerEnter(Collider c){
		if (c.GetComponent<BallScript> () != null) {
			effectObject.SetActive (true);
		}
	}


}
