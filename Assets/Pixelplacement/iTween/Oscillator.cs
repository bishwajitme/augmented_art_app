﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour {

	public float timeCounter = 0;
	public float x = 0;
	public float y = 0;
	public float z = 0;
	public float speed;
	public float width;
	public float height;

	// Use this for initialization
	void Start () {

		speed = 2;
		width = width;
		height = height;

	}
	
	// Update is called once per frame
	void Update () {

		timeCounter += Time.deltaTime*speed;

		y = Mathf.Tan (timeCounter)*width;
		x = Mathf.Sin (timeCounter)*height;

		transform.position = new Vector3 (x, y, z);		
	}
}
