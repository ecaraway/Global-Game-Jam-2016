﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

public GameObject player;
private Vector3 offset;

	// Use this for initialization
	void Start () {
	offset = transform.position - player.transform.position;
    //offset.y = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = player.transform.position + offset;
	}
}
