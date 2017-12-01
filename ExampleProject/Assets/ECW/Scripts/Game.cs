using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	Player player;
	Enemy enemy;
	// Use this for initialization
	void Start () {
		player = new Player (this);
		enemy = new Enemy ();
	}
	
	// Update is called once per frame
	void Update () {
		Messenger.Broadcast<int> (Messages.GameUpdate, 0);
	}

	public Enemy Enemy(){
		return enemy;
	}
}
