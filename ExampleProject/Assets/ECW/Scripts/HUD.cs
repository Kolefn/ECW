using System.Collections;
using System.Collections.Generic;
public class HUD {

	RangeIndicator enemy_health;

	public HUD(){
		enemy_health = new RangeIndicator ("HealthBar");
	}

	public void SetEnemyHealth(float health, float max_health){
		enemy_health.Set(health, 0, max_health);
	}

	public void SetEnemyHealth(float health){
		enemy_health.Set(health);
	}
}
