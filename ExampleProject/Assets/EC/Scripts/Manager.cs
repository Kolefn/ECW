using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	IShape active_shape;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift)) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				if(active_shape != null) active_shape.disable ();
				active_shape = gameObject.AddComponent<Sphere> ();
				active_shape.enable ();
			}

			else if (Input.GetKeyDown (KeyCode.Alpha2)) {
				if(active_shape != null) active_shape.disable ();
				active_shape = gameObject.AddComponent<Cube> ();
				active_shape.enable ();
			}

			else if (Input.GetKeyDown (KeyCode.Alpha3)) {
				if(active_shape != null) active_shape.disable ();
				active_shape = gameObject.AddComponent<Cylinder> ();
				active_shape.enable ();
			}


		}
	}
}

