using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller {

	MovementModel mov_model;
	CharacterView view;
	CharacterView enemy_view;
	EnemyModel enemy_model;
	PlayerModel player_model;
	EnemyHealthView enemy_health_view;

	public Controller() {
		mov_model = new MovementModel ();
		view = new CharacterView ("Cube");
		enemy_view = new CharacterView ("Sphere", new Vector3(0,2,-2));

		enemy_model = new EnemyModel ();
		player_model = new PlayerModel ();
		enemy_health_view = new EnemyHealthView ();
		enemy_health_view.Set (enemy_model.Health (), 0, enemy_model.MaxHealth ());
	}

	public void Update () {
		view.UpdateCharacterPosition (mov_model.GetMovement ());
		enemy_model.Damage (player_model.GetDamage ());
		enemy_health_view.Set (enemy_model.Health ());
		if (enemy_model.Dead ()){
			enemy_view.Destroy ();
			enemy_health_view.Hide ();
		}
	}
}
