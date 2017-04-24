using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitButtom : MonoBehaviour {

	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
			Application.Quit ();
		}
	}
}
