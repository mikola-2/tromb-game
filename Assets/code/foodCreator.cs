using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class foodCreator : MonoBehaviour {
	public GameObject prefabFood;
	public GameObject prefabEnemy;
	public GameObject prefabSuperFood;
	public Text scoreText;
	int respIndex = 0;
	int respIntTime = 20;
	int respIndex2 = 0;
	int respIntTime2 = 15;
	int a = 1;
	public int countAddedFood;
	public static int winNum;

	void Start(){
		winNum = 20;
	}

	void Update () {
		respIndex++;
		respIndex2++;
		Vector3 posF = new Vector3(0+Random.Range(-1f, 1f), 6, 0);
		Vector3 posE = new Vector3(0+Random.Range(-1f, 1f), 6, 0);
		if(respIndex==respIntTime){
			respIndex = 0;
			respIntTime = 0;
			var randomTimeRespawn =Random.Range (5, 20);
			var randomTypeFood = Random.Range (0, 5);
			respIntTime = 10 + randomTimeRespawn;

			if (a != randomTypeFood ) {
				Instantiate (prefabFood, posF, transform.rotation);
			} else {
				Instantiate (prefabSuperFood, posF, transform.rotation);
				//Instantiate (prefabEnemy, posE, transform.rotation);
			}
		}
		if (respIndex2 == respIntTime2) {
			respIndex2 = 0;
			respIntTime2 = 0;
			var randomTimeRespawn2 =Random.Range (5, 20);
			respIntTime2 = 20 + randomTimeRespawn2;
			Instantiate (prefabEnemy, posE, transform.rotation);
		}
		countAddedFood = PlayerPrefs.GetInt ("foodScore");
		scoreText.text = countAddedFood + "/" + winNum;
		if (countAddedFood == winNum) {
			SceneManager.LoadScene ("endVideo");
		}
	}
}