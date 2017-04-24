using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour {
	public GameObject creator;
	public float speed = 2f;
	bool inTrig = false;
	public int foodScore;

	void Update(){
		if(inTrig == false){
			transform.Translate (new Vector3(0f, -0.09f, 0f));
		}
	}


	void OnTriggerEnter2D(Collider2D col){
		if((col.gameObject.name == "mainChar")||(col.gameObject.tag == "food")||(col.gameObject.tag == "superFood")){
			inTrig = true;
			Destroy (this.gameObject);
		}
	}
}