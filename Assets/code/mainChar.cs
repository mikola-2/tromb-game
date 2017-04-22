using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainChar : MonoBehaviour {
	public Rigidbody2D body;
	public float speed = 5f;
	public float mousePos;
	public float charPos;
	//public Transform body;

	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}

	void Update () {
	if(Input.GetMouseButtonDown(0)){
			//if (Input.mousePosition.x > body.transform.position.x) {
			//	body.AddForce (new Vector2(100, 0));
			//} else {
			//	body.AddForce (new Vector2(-100, 0));
			//}
		}
	}
		
	}
