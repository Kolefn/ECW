using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView {

	GameObject body;
	CharacterController cc;

	public CharacterView(string shape){
		body = (GameObject)GameObject.Instantiate(Resources.Load(shape));
		cc = body.AddComponent<CharacterController> ();
	}

	public CharacterView(string shape, Vector3 startp) : this(shape) {
		body.transform.position = startp;
	}

	public void UpdateCharacterPosition(Vector3 dp){
		cc.Move (dp);
	}


	public void Destroy(){
		GameObject.Destroy (body);
	}
}
