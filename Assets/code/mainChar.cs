using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainChar : MonoBehaviour {
	public int score = 0;
	public int foodScore;

	void Start(){
		PlayerPrefs.SetInt ("foodScore", score);

	}
	//void Update(){
		//foodScore = PlayerPrefs.GetInt ("foodScore");
		//if(foodScore == 0){
		//	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		//}
	//}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "food"){
			col.gameObject.transform.parent = this.gameObject.transform;
			col.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + Random.Range(-0.5f, 0.5f), this.gameObject.transform.position.y + Random.Range(0f,0.5f), this.gameObject.transform.position.z);
		}
		if (col.gameObject.tag == "enemy"||col.gameObject.tag == "border") {
			if(PlayerPrefs.GetInt("foodScore") == 0){
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
				PlayerPrefs.DeleteKey("foodScore");
			}
		}
	}
}
