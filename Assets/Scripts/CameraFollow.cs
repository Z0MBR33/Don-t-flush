using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public GameObject target;

    void Update()
    {
        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position, 0.1f);
        }
    }
}
