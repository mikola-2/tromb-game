using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainChar : MonoBehaviour {
	public Rigidbody2D body;
	public float speed = 5f;
	public Vector3 mousePos;
	public Vector3 charPos;
	//public float mousePos;
	//public float charPos;
	//public Transform body;

	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		
	}
}
