using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel {



	public PlayerModel(){}


	public float GetDamage(){
		float dmg = 0;
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			dmg += 10;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			dmg += 5;
		} else if (Input.GetKeyDown(KeyCode.Alpha3)){
			dmg += 1;
		}

		return dmg;
	}
}
