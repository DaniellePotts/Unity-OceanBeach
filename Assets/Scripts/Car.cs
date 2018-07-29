using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Car : MonoBehaviour {

	public int speed = 0;
	public GameObject carObject;
	public int laps = 0;
	public int targetCounter = 0;
	public int currentPos = 0;

	private bool CanMove = true;

	public bool AbleToMove()
	{
		return CanMove;
	}

	public void SetCanMove()
	{
		this.CanMove = !CanMove;
	}

	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == "Ghost Hunt Car")
		{
			SetCanMove();
		}
	}
}
