using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, IShape {

	GameObject body;

	public void enable () {

		body = (GameObject)Instantiate(Resources.Load("Sphere"));
		body.AddComponent<Floating> ().enable(KeyCode.A);
	}

	public void disable(){
		GameObject.Destroy (body);
	}
		
}
