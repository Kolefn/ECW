using System.Collections;
using System.Collections.Generic;

public class Movement  {

	const float SPEED = 3;
	const float GRAVITY = 3;
	Body body;
	FakeRigidBody frg;



	public Movement(Body body){
		this.body = body;
		this.frg = new FakeRigidBody (body);
		Messenger.AddListener<int> (Messages.GameUpdate, Update);

	}


	void Update(int n){
		float dt = Clock.DeltaTime();
		float dp = SPEED * dt;
		Vector p = new Vector ();
		if (UserInput.GetKeyHeldDown("A")) {
			p.SetX(p.X - dp);
		}
		if (UserInput.GetKeyHeldDown("D")) {
			p.SetX(p.X + dp);
		}
		if(UserInput.GetKeyHeldDown("S")){
			p.SetZ(p.Z - dp);
		}
		if(UserInput.GetKeyHeldDown("W")){
			p.SetZ(p.Z + dp);
		}

		p.SetY(p.Y - (GRAVITY * dt));

		frg.Move(p);


	}
}
