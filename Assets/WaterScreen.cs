using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScreen : MonoBehaviour {

    public GameObject root;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, transform.position.y, transform.position.z);

    }
}
