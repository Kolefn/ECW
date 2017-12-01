using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeRigidBody  {

	GameObject go;
	CharacterController cc;

	public FakeRigidBody(Body body){
		go = body.Unwrap ();
		cc = go.AddComponent<CharacterController> ();
	}


	public void Move(Vector dp){
		cc.Move (dp.Vector3 ());
	}


}
