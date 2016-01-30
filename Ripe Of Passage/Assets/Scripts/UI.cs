﻿using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

    bool listUnrolled = false;
    public GameObject scroll;

	void Start ()
    {
        scroll.SetActive(false);
	}

	void Update ()
    {
        if (Input.GetKeyDown("space"))
            listUnrolled = !listUnrolled;
        scroll.SetActive(listUnrolled);
    }
}
