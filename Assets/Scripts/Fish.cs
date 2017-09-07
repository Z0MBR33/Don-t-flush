using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {
    public float rightPosition;
    public float leftPosition; // 
    public float speed;
    public int Layer;

    private int currentDirection;
    private float currentPositionX;
    private GameObject myObject;
	// Use this for initialization
	void Start () {
        myObject = gameObject;//GetComponent<GameObject>();
        //leftPosition = myObject.transform.position.x;
        currentDirection = -1;
	}
	
	// Update is called once per frame
	void Update () {
        currentPositionX = myObject.transform.transform.position.x;
        if (currentPositionX <= leftPosition || currentPositionX >= rightPosition)
        {
            currentDirection = currentDirection * -1;
            myObject.transform.localScale = new Vector3(-currentDirection,1,1);
        }

        myObject.transform.position += new Vector3(speed * currentDirection,0,0);
	}
}
