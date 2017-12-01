using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UserInput
{


	public static bool GetKeyDown (string key)
	{ 
		return Input.GetKeyDown (StringToKey (key));
	}

	public static bool GetKeyUp (string key)
	{
		return Input.GetKeyUp (StringToKey (key));
	}

	public static bool GetKeyHeldDown (string key)
	{
		return Input.GetKey (StringToKey (key));

	}


	private static KeyCode StringToKey (string s)
	{
		return (KeyCode)System.Enum.Parse (typeof(KeyCode), s);
	}


}

