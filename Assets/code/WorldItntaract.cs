using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldItntaract : MonoBehaviour {
	//private NavMeshAgent playerAgent;
	public Rigidbody2D body;
	public float speed = 5f;

	void Start(){
		//playerAgent = GetComponent<NavMeshAgent> ();
		body = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if(Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()){
			GetInteraction ();
		}
	}

	void GetInteraction(){
		Ray intRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit intInfo;
		if(Physics.Raycast(intRay, out intInfo, Mathf.Infinity)){
			GameObject intObj = intInfo.collider.gameObject;
			if (intObj.tag == "") {

			} else {
				//playerAgent.destination = intInfo.point;
				if(intInfo.point.x > 0){
					body.AddForce (new Vector2(100, 0));
				}
			}
		}
	}
}
