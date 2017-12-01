using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IShape {

	GameObject body;

	public void enable () {

		body = (GameObject)Instantiate(Resources.Load("Cube"));
		body.AddComponent<Spinner> ().enable(KeyCode.A, 0); //0 for x axis spin

		//adding another motion ability is as easy as!
		body.AddComponent<Spinner> ().enable(KeyCode.S, 1); 
		body.AddComponent<Spinner> ().enable(KeyCode.D, 2); 
		body.AddComponent<Floating> ().enable(KeyCode.F);
	}

	public void disable(){
		GameObject.Destroy (body);
	}
}
