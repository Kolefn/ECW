using System.Collections;
using System.Collections.Generic;
public class AbilitySystem  {

	TargetSystem ts;

	Life target_life;

	public AbilitySystem(TargetSystem ts){
		this.ts = ts;
		Messenger.AddListener<int> (Messages.GameUpdate, Update);
	}


	void Update(int n){
		if (UserInput.GetKeyDown ("Tab")) {
			target_life = ts.TargetNearbyEnemy();
		} else if(UserInput.GetKeyDown("Alpha1")){
			if (target_life != null) {
				target_life.Damage (5);
			}
		}
	}
}
