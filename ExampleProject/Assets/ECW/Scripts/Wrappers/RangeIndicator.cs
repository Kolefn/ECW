using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangeIndicator {

	GameObject go;
	Slider slider;

	public RangeIndicator(string prefab){
		go = (GameObject)GameObject.Instantiate (Resources.Load (prefab));
		slider = go.GetComponentInChildren<Slider> ();
	}

	public void Set(float val, float min, float max){
		slider.value = val;
		slider.maxValue = max;
		slider.minValue = min;
	}
	public void Set(float val){
		slider.value = val;
	}
}
