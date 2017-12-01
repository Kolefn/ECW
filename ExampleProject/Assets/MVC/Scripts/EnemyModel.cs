using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel{
	private const float MAX_HEALTH = 100;
	private float health = MAX_HEALTH;
	private bool dead = false;

	public EnemyModel(){}

	public void Damage(float damage){
		health -= damage;
		if (health <= 0)
			dead = true;
	}

	public float Health(){
		return health;
	}

	public float MaxHealth(){
		return MAX_HEALTH;
	}

	public bool Dead(){
		return dead;
	}

}
