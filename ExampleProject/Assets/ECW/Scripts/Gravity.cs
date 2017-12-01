using System.Collections;
using System.Collections.Generic;
public class Gravity  {


	const float GRAVITY = 3;
	Body body;
	FakeRigidBody frg;



	public Gravity(Body body){
		this.body = body;
		this.frg = new FakeRigidBody (body);

	}


	public void Apply(){
		float dt = Clock.DeltaTime();
		Vector p = new Vector ();
		p.SetY(p.Y - (GRAVITY * dt));
		frg.Move(p);
	}
}
