﻿using UnityEngine;
using System.Collections;

public class parallax : MonoBehaviour {

	public float speed = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		renderer.material.mainTextureOffset = new Vector2(Time.time * speed,0);
	
	}
}
