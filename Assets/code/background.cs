using UnityEngine;

public class background:MonoBehaviour{

	float speed = -0.1f;

	void Update(){
		transform.Translate (new Vector3(0f, speed, 0f));
		if(transform.position.y < -5f){
			transform.position = new Vector3 (0f, 7.3f, 1f);
		}
	}




}
