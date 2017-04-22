using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour {
	public Animator anim;
	public GameObject creator;
	//public Transform transform;
	//public float speed = 2f;
	//Rigidbody2D bodyFood;

	//void Start(){
		//bodyFood = GetComponent<Rigidbody2D> ();
		//bodyFood.AddForce (new Vector2(0, -500f));
		//transform.position = new Vector3(0, -20*Time.deltaTime*speed, 0);
	//}
		

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "border"){
			this.gameObject.transform.parent = creator.gameObject.transform;
			Destroy (this.gameObject);
			anim = GetComponent<Animator> ();
			anim.enabled = true;
		}
	}
}
