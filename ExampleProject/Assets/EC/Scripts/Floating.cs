using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {

	private KeyCode trigger;
	private float origin;
	private bool _enabled;
	private bool motion_enabled;
	private float local_time;

		
	// Use this for initialization
	public void enable (KeyCode trigger) {

		origin = gameObject.transform.position.y;
		this.trigger = trigger;
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
			Vector3 p = gameObject.transform.position;
			float y = p.y;
			y = origin + Mathf.Sin (local_time);
			p.Set (p.x, y, p.z);
			gameObject.transform.position = p;
		}
	}
}
