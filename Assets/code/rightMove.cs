using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightMove : MonoBehaviour {
	public GameObject mainChar;
	public Rigidbody2D body;
	public bool isMove;

	void Start () {
		body = mainChar.GetComponent<Rigidbody2D> ();
	}

	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
			if (isMove == false) {
			body.AddForce (new Vector2(100, 0));
				isMove = true;
			} else {
				body.AddForce (new Vector2 (200, 0));
				isMove = false;
			}
		}
	}
}
