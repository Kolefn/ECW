using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementModel {

	float SPEED =  3;
	float GRAVITY = 5;


	public MovementModel() {
		
	}

	public Vector3 GetMovement(){
		float dt = Time.deltaTime;
		float dp = SPEED * dt;
		Vector3 p = new Vector3 ();
		if (Input.GetKey(KeyCode.A)) {
			p.x -= dp;
		}
		if (Input.GetKey(KeyCode.D)) {
			p.x += dp;
		}
		if(Input.GetKey(KeyCode.S)){
			p.z -= dp;
		}
		if(Input.GetKey(KeyCode.W)){
			p.z += dp;
		}

		p.y -= GRAVITY * dt;

		return p;
	}
}
