using System.Collections;
using System.Collections.Generic;

public class Life  {

	private float MAX_HEALTH;
	private float health;
	private bool dead = false;

	public Life(float max){
		MAX_HEALTH = max;
		health = max;
	}

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
