using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodCreator : MonoBehaviour {
	public GameObject prefabFood;
	public Animator anim;
	int respIndex = 0;
	int respIntTime = 90;
	//public Animation[] animations = new Animation[5];
	int animMove;

	void Start () {
		anim = GetComponent<Animator> ();
	}

	void Update () {
		respIndex++;
		//int sw = Screen.width;
		//int sh = Screen.height;
		Vector3 pos = /*Camera.main.ViewportToWorldPoint (*/new Vector3(0+Random.Range(-4, 4), 6, 0);
		if(respIndex>=respIntTime){
			respIndex = 0;
			GameObject food = Instantiate (prefabFood, pos, transform.rotation);
			anim = food.GetComponent<Animator> ();
			anim.enabled = true;
			//anim.applyRootMotion = false;
		}
	}
}
