using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightMove : MonoBehaviour {
	public GameObject mainChar;
	public Rigidbody2D body;
	public float move;

	void Start () {
		body = mainChar.GetComponent<Rigidbody2D> ();
	}

	void Update(){
		move = Input.GetAxis ("Horizontal");
		if (move > 0) {
			body.velocity = Vector2.zero;
			body.AddForce (new Vector2(100, 0));
		}
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			body.velocity = Vector2.zero;
			body.AddForce (new Vector2(100, 0));
		}
	}
}
