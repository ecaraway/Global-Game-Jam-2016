﻿using UnityEngine;
using System.Collections;

public class ReturnToMM : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            Application.LoadLevel("TitleScreen");
        }
	}
}
