using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodCreator : MonoBehaviour {
	public GameObject prefabFood;
	public GameObject prefabEnemy;
	int respIndex = 0;
	int respIntTime = 10;
	int a = 1;


	void Update () {
		respIndex++;
		Vector3 posF = new Vector3(0+Random.Range(-1f, 1f), 6, 0);
		Vector3 posE = new Vector3(0+Random.Range(-1f, 1f), 6, 0);
		if(respIndex==respIntTime){
			respIndex = 0;
			respIntTime = 0;
			var randomTimeRespawn =Random.Range (5, 20);
			var randomTypeItem =Random.Range (0, 99)%2;
			respIntTime = 10 + randomTimeRespawn;
			if (a == randomTypeItem ) {
				/*GameObject food = */Instantiate (prefabFood, posF, transform.rotation);
			} else {
				/*GameObject enemy = */Instantiate (prefabEnemy, posE, transform.rotation);
			}
		}
	}
}