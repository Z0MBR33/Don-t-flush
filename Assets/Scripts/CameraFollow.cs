﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public GameObject target;

    void Update()
    {
        transform.position = target.transform.position;

    }
}
