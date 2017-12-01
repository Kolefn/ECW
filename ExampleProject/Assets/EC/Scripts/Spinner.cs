using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

	private KeyCode trigger;
	private bool _enabled;
	private bool motion_enabled;
	private float local_time;
	private int axis;


	// Use this for initialization
	public void enable (KeyCode trigger, int axis) {
		this.trigger = trigger;
		this.axis = axis;
		_enabled = true;
	}

	public void disable (){
		_enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (trigger)){ 

			motion_enabled = !motion_enabled;
		}

		if(motion_enabled && _enabled) {
			local_time+= Time.deltaTime;
			motion_enabled = true;
			Quaternion r = gameObject.transform.rotation;
			float a = Mathf.Cos(local_time);
			switch (axis) {
			case 0:
				r.Set (a, r.y, r.z, r.w);
				break;
			case 1:
				r.Set (r.x, a, r.z, r.w);
				break;
			case 2:
				r.Set (r.x, r.y, a, r.w);
				break;
			}
			gameObject.transform.rotation = r;
		}
	}
}
