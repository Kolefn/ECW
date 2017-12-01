using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switcher : MonoBehaviour {
	GameObject shape;
	string shapeName;

	float floatBase = 0;
	bool floating = false;
	bool spinx = false;
	bool spiny = false;
	bool spinz = false;

	// Use this for initialization
	void Start () {
		shapeName = "Sphere";
		shape = (GameObject)Instantiate(Resources.Load("Sphere"));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift)) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {

				shapeName = "Sphere";
				SwapShape (shapeName);
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				shapeName = "Cube";
				SwapShape (shapeName);
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				shapeName = "Cylinder";
				SwapShape (shapeName);
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				shapeName = "Capsule";
				SwapShape (shapeName);
			}

		}
		switch (shapeName) {
		case "Sphere":
			HandleSphereAbilities (); break;
		case "Cube":
			HandleCubeAbilities (); break;
		case "Cylinder":
			HandleCylinderAbilities ();
			break;
		case "Capsule":
			HandleCapsuleAbilities ();
			break;
		}


		if (floating) {
			Vector3 p = shape.transform.position;
			float y = p.y;
			y = floatBase + Mathf.Sin (Time.time);
			p.Set (p.x, y, p.z);
			shape.transform.position = p;
		}
		if (spinz) {
			Quaternion r = shape.transform.rotation;
			float z = r.z;
			z = Mathf.Cos(Time.time);
			r.Set (r.x, r.y, z, r.w);
			shape.transform.rotation = r;
		}
		if (spiny) {
			Quaternion r = shape.transform.rotation;
			float y = r.y;
			y = Mathf.Cos(Time.time);
			r.Set (r.x, y, r.z, r.w);
			shape.transform.rotation = r;
		}
		if (spinx) {
			Quaternion r = shape.transform.rotation;
			float x = r.x;
			x = Mathf.Cos(Time.time);
			r.Set (x, r.y, r.z, r.w);
			shape.transform.rotation = r;
		}

	}


	void SwapShape(string s){
	
		GameObject.Destroy (shape);
		shape = (GameObject)Instantiate(Resources.Load(s));
	}

	void HandleSphereAbilities(){

		spinz = false; spinx = false; spiny = false; 
		if (Input.GetKeyDown (KeyCode.A)) {floating = !floating; floatBase = shape.transform.position.y;}
	}

	void HandleCubeAbilities(){

		spiny = false; spinx = false;  
		if (Input.GetKeyDown (KeyCode.A)) {spinz = !spinz;}
		if (Input.GetKeyDown (KeyCode.S)) {floating = !floating; floatBase = shape.transform.position.y;}

	}

	void HandleCylinderAbilities(){

		spinz = false; spinx = false; floating = false; 
		if (Input.GetKeyDown (KeyCode.A)) { spiny = !spiny; }
	}

	void HandleCapsuleAbilities(){

		spinz = false; spiny = false; floating = false; 
		if (Input.GetKeyDown (KeyCode.A)) {spinx = !spinx;}
	}




}
