﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoWalk : MonoBehaviour {
	
	public int speed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
	}

	public void onTriggerEnter (Collider collide)
	{
		if (collide.gameObject.CompareTag("Trophytag")) {
			SceneManager.LoadScene ("EndScene");
		}
	}
}
