using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour {

	Controller controller;
	// Use this for initialization
	void Start () {
		controller = new Controller ();
	}
	
	// Update is called once per frame
	void Update () {
		controller.Update ();
	}
}
