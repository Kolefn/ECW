using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GAME OBJECT WRAPPER
public class Body {
	private GameObject go;
	public Body(string prefab) {
		go = (GameObject)GameObject.Instantiate(Resources.Load(prefab));
	}


	public GameObject Unwrap(){
		return go;
	}

	public void Destroy(){
		GameObject.Destroy (go);
	}


}
