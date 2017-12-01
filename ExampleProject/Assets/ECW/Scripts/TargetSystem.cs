using System.Collections;
using System.Collections.Generic;
public class TargetSystem  {
	Game game;
	HUD hud;
	Enemy enemy_target;

	public TargetSystem(Game game, HUD hud){
		this.game = game;
		this.hud = hud;
		Messenger.AddListener<int> (Messages.GameUpdate, Update);

	}

	public Life TargetNearbyEnemy(){

		enemy_target = game.Enemy();
		hud.SetEnemyHealth (enemy_target.Life().Health (), enemy_target.Life().MaxHealth());
		return enemy_target.Life();
	}

	void Update(int n){
		if (enemy_target != null) {
			hud.SetEnemyHealth (enemy_target.Life().Health ());
		}
	}
}
