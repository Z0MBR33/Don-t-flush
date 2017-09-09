using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbles : MonoBehaviour {
    public int life = 2;
    public int scoreValue;
    void Start () {

    }
	
	void Update () {

        float rand = Random.Range(0.3f, 0.2f);
        transform.position = new Vector3(transform.position.x, transform.position.y + rand, transform.position.z);
    }

    
}
