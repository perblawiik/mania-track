﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCar : MonoBehaviour {

    private Vector3 startPosition;
    private Vector3 forwardVector;
    public float speed;

	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        forwardVector = Vector3.forward * speed;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(forwardVector * Time.deltaTime);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EndOfRoad"))
        {
            Destroy(gameObject);
            Destroy(this);
        }
    }
}
