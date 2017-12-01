using System.Collections;
using System.Collections.Generic;

//really basic death animation - kinda hacky for now
public class DeathAnimation  {

	Body body;
	Life life;
	Gravity gravity;

	float duration = 3f; //3 sec animation

	public DeathAnimation(Body body, Life life){
		this.body = body;
		this.life = life;
		gravity = new Gravity (body);
		Messenger.AddListener<int> (Messages.GameUpdate, Update);

	}
	
	// Update is called once per frame
	void Update (int n) {
		if (duration <= 0) {
			gravity = null;
			body.Destroy ();
		}
		else if (life.Dead ()) {
			gravity.Apply ();
			duration -= Clock.DeltaTime ();
		}
	}
}
