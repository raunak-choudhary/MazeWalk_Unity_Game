﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTrophy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 45, 0) * Time.deltaTime);		
	}
}
