using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainChar : MonoBehaviour {
	public Animator anim;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "food"){
			col.gameObject.transform.parent = this.gameObject.transform;
			anim = col.gameObject.GetComponent<Animator> ();
			anim.enabled = false;
		}
	}
}
