using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealthView {
	GameObject canvas;
	Slider slider;
	public EnemyHealthView(){
		canvas = (GameObject)GameObject.Instantiate(Resources.Load("HealthBar"));
		slider = canvas.GetComponentInChildren<Slider> ();
	}

	public void Set(float val, float min, float max){
		slider.maxValue = max;
		slider.minValue = min;
		slider.value = val;
	}

	public void Set(float val){
		slider.value = val;
	}

	public void Hide(){
		GameObject.Destroy (canvas);
	}

}
