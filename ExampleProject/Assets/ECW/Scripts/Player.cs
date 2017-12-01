using System.Collections;
using System.Collections.Generic;
public class Player  {
	Game game;
	Body body;
	Movement movement;
	HUD hud;
	TargetSystem ts;
	AbilitySystem abils;

	public Player(Game game){

		this.game = game;
		body = new Body ("cube");
		movement = new Movement (body);
		hud = new HUD ();
		ts = new TargetSystem (game, hud);
		abils = new AbilitySystem (ts);
	}



}
