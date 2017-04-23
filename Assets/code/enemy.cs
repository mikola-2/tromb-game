using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour {
	public GameObject creator;
	public float speed = -0.2f;
	bool inTrig = false;
	public int foodScore;

	void Update(){
		if(inTrig == false){
			transform.Translate (new Vector3(0f, speed, 0f));
		}
	}


	void OnTriggerEnter2D(Collider2D col){
		if((col.gameObject.name == "mainChar")||(col.gameObject.tag == "food")){
			inTrig = true;
			Destroy (this.gameObject);
			foodScore = PlayerPrefs.GetInt ("foodScore") - 1;
			PlayerPrefs.SetInt ("foodScore", foodScore);
			if (foodScore == 0) {
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
				PlayerPrefs.DeleteKey("foodScore");
			}
		}
	}
}