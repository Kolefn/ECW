using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Clock  {

	public static float DeltaTime(){
		return Time.deltaTime;
	}

	public static float TotalTime(){
		return Time.time;
	}
}
