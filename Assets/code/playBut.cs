using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playBut : MonoBehaviour {
	public GameObject playButton;
	public Sprite[] sprites = new Sprite[2];

	void OnMouseEnter(){
		playButton.GetComponent<SpriteRenderer> ().sprite = sprites [0];
	}

	void OnMouseExit(){
		playButton.GetComponent<SpriteRenderer> ().sprite = sprites [0];
	}

	void OnMouseOver(){
		playButton.GetComponent<SpriteRenderer> ().sprite = sprites [1];
		if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene ("level1");
		}
	}
}
