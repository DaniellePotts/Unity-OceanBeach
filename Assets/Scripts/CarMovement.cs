using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CarMovement : MonoBehaviour
{

	public Transform[] target;
	private const int carCapacity = 1;
	public Car[] cars = new Car[carCapacity];

	void Update()
	{
		for (var i = 0; i < cars.Length; i++)
		{
			Debug.Log(cars[i].gameObject.name + " able to move: " + cars[i].AbleToMove());

			if (cars[i].AbleToMove())
			{
				if (cars[i].targetCounter == target.Length)
				{
					cars[i].laps++;
					cars[i].targetCounter = 0;
				}

				if (cars[i].laps < 2)
				{
					if (cars[i].carObject.transform.position != target[cars[i].currentPos].position)
					{
						Vector3 pos = Vector3.MoveTowards(cars[i].carObject.transform.position, target[cars[i].currentPos].position, cars[i].speed * Time.deltaTime);
						cars[i].carObject.GetComponent<Rigidbody>().MovePosition(pos);
					}
					else
					{
						cars[i].currentPos = (cars[i].currentPos + 1) % target.Length;
						cars[i].targetCounter++;
					}
				}
			}
		}
	}
}
