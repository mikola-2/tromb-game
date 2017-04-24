using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class foodMove : MonoBehaviour {
	public GameObject creator;
	public float speed = -0.1f;
	public bool inTrig = false;
	public int foodScore;

	void Update(){
		if(inTrig == false){
		transform.Translate (new Vector3(0f, speed, 0f));
		}
	}
		

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "enemy"){
			this.gameObject.transform.parent = creator.gameObject.transform;
			Destroy (this.gameObject);
			foodScore = PlayerPrefs.GetInt ("foodScore");
			if (foodScore != 0) {
				foodScore--;
				PlayerPrefs.SetInt ("foodScore", foodScore);
			}
		}
		if((col.gameObject.name == "mainChar")||(col.gameObject.tag == "food")){
			inTrig = true;
			if(col.gameObject.tag == "food"){
			foodScore = PlayerPrefs.GetInt ("foodScore");
				if (foodScore < 10) {
					foodScore++;
					PlayerPrefs.SetInt ("foodScore", foodScore);
				}
			}
		}
	}
}
