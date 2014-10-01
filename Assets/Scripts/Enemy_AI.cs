﻿using UnityEngine;
using System.Collections;

public class Enemy_AI : MonoBehaviour 
{
	private enum directions
	{
		left,
		right
	};

	private directions currentDirection;

	// Use this for initialization
	void Start () 
	{
		currentDirection = directions.right;
	}
	
	// Update is called once per frame
	void Update () 
	{
					switch ( currentDirection )
					{
									case directions.left:
													transform.Translate(Vector3.left * 0.05f);
													break;
									case directions.right:
													transform.Translate(Vector3.right * 0.05f);
													break;
					}

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Left")
		{
			currentDirection = directions.right;
		}
		if(other.gameObject.tag == "Right")
		{
			currentDirection = directions.left;
		}
	}
}