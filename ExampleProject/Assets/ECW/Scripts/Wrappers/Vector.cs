using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector
{
	private Vector3 vector;

	public float X { get { return vector.x; } }

	public float Y { get { return vector.y; } }

	public float Z { get { return vector.z; } }

	public Vector (float x = 0, float y = 0, float z = 0)
	{
		this.vector = new Vector3 (x, y, z);
	}


	public void Set (float x, float y, float z)
	{
		vector.Set (x, y, z);
	}

	public void SetX(float x){
		vector.x = x;
	}

	public void SetY(float y){
		vector.y = y;
	}

	public void SetZ(float z){
	
		vector.z = z;
	}
		

	// Overload + operator to add two Position objects.
	public static Vector operator+ (Vector b, Vector c)
	{
		Vector newVector = new Vector ();
		newVector.Set (b.X + c.X, b.Y + c.Y, b.Z + c.Z);
		return newVector;
	}

	// Overload - operator to subtract two Position objects.
	public static Vector operator- (Vector b, Vector c)
	{
		Vector newVector = new Vector ();
		newVector.Set (b.X - c.X, b.Y - c.Y, b.Z - c.Z);
		return newVector;
	}

	public static Vector operator* (Vector b, float c)
	{
		Vector newVector = new Vector ();
		newVector.Set (b.X * c, b.Y * c, b.Z * c);
		return newVector;
	}

	public static Vector ToVector (Vector3 v1)
	{
		return new Vector (v1.x, v1.y, v1.z);
	}

	public static Vector3 ToVector3 (Vector v1)
	{
		return new Vector3 (v1.X, v1.Y, v1.Z);
	}

	public float Magnitude ()
	{
		return vector.magnitude;

	}

	public Vector3 Vector3 ()
	{
		return vector;
	}



}
