using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour, IShape {

	GameObject body;

	public void enable () {

		body = (GameObject)Instantiate(Resources.Load("Cylinder"));
		body.AddComponent<Spinner> ().enable(KeyCode.A, 1); //1 for y axis spin

		//adding another motion ability is as easy as!
		body.AddComponent<Spinner> ().enable(KeyCode.S, 2); 
	}

	public void disable(){
		GameObject.Destroy (body);
	}
}
