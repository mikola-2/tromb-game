using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainChar : MonoBehaviour {
	public Rigidbody2D food;
	public Animator anim;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "food"){
			col.gameObject.transform.parent = this.gameObject.transform;
			//food = col.gameObject.GetComponent<Rigidbody2D> ();
			//food.gravityScale = 0;
			//food.mass = 0;
			anim = col.gameObject.GetComponent<Animator> ();
			anim.enabled = false;
		}
	}
}
