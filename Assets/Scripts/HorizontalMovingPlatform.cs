﻿using UnityEngine;

public class HorizontalMovingPlatform : MonoBehaviour
{
	public float platformSpeed = 2f;
	bool endPoint;
	
	// Update is called once per frame
	void FixedUpdate()
	{
		if (endPoint)
		{
			transform.position += Vector3.right * platformSpeed * Time.deltaTime;
		}
		else
		{
			transform.position -= Vector3.right * platformSpeed * Time.deltaTime;
		}
		if (transform.position.x >= 4.6f)
		{
			endPoint = false;
		}
		if (transform.position.x <= -4.6f)
		{
			endPoint = true;
		}
	}
}
