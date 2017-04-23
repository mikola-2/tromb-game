using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class foodMove : MonoBehaviour {
	public GameObject creator;
	public float speed = -0.2f;
	public bool inTrig = false;
	public int foodScore;

	void Update(){
		if(inTrig == false){
		transform.Translate (new Vector3(0f, speed, 0f));
		}
	}
		

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "enemy"||col.gameObject.tag == "border"){
			this.gameObject.transform.parent = creator.gameObject.transform;
			Destroy (this.gameObject);
			foodScore = PlayerPrefs.GetInt ("foodScore") - 1;
			PlayerPrefs.SetInt ("foodScore", foodScore);
		}
		if((col.gameObject.name == "mainChar")||(col.gameObject.tag == "food")){
			inTrig = true;
			foodScore = PlayerPrefs.GetInt ("foodScore") + 1;
			PlayerPrefs.SetInt ("foodScore", foodScore);
		}
	}
}
