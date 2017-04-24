using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightMove : MonoBehaviour {
	public GameObject mainChar;
	public Rigidbody2D body;

	void Start () {
		body = mainChar.GetComponent<Rigidbody2D> ();
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			body.velocity = Vector2.zero;
			body.AddForce (new Vector2(100, 0));
		}
	}
}
