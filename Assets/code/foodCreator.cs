using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodCreator : MonoBehaviour {
	public GameObject prefabFood;
	int respIndex = 0;
	int respIntTime = 60;

	void Start () {
		
	}

	void Update () {
		respIndex++;
	}
}
