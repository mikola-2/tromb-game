using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainChar : MonoBehaviour {
	public int score = 0;
	public int foodScore;
	public AudioSource nyam;
	public AudioSource fail;

	void Start(){
		PlayerPrefs.SetInt ("foodScore", score);
	}


	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "food"){
			col.gameObject.transform.parent = this.gameObject.transform;
			col.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + Random.Range(-0.5f, 0.5f), this.gameObject.transform.position.y + Random.Range(0f,0.5f), this.gameObject.transform.position.z);
			foodScore = PlayerPrefs.GetInt ("foodScore");
			if (foodScore < 10) {
				foodScore++;
				PlayerPrefs.SetInt ("foodScore", foodScore);
			}
			PlaySound (nyam);	
		}
		if (col.gameObject.tag == "enemy") {
			foodScore = PlayerPrefs.GetInt ("foodScore");
			if(foodScore != 0){
				foodScore--;
			PlayerPrefs.SetInt ("foodScore", foodScore);
			}
			PlaySound (fail);	
		}
	}

	private void PlaySound(AudioSource sound)
	{
		if (!sound.isPlaying) {
			sound.Play ();
		}
	}
		
}
