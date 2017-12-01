using System.Collections;
using System.Collections.Generic;
public class Enemy {

	Life life;
	Body body;
	DeathAnimation da;

	public Enemy(){
		body = new Body ("sphere");
		life = new Life (100);
		da = new DeathAnimation (body, life);
	}

	public Life Life(){
		return life;
	}
		

}
