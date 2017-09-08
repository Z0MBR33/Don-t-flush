using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRight : MonoBehaviour {
    public float maxRotAngle;
    public float minRotAngle;
    public float rotationSpeed;

    private bool back;
    private bool action;
	// Use this for initialization
	void Start () {
        action = false;
        back = true;
	}
	
	// Update is called once per frame
	void Update () {
        whichButton();
        if (action)
        {
            if(transform.eulerAngles.z >= maxRotAngle)
            {
                gameObject.GetComponent<Rigidbody2D>().angularVelocity = -500;
                //move Forward
                //transform.Rotate(0, 0, rotationSpeed);
                
            }
            if(transform.eulerAngles.z >= 70)
            {
                action = false;

            }
        }
        if (!action && !back)
        {
            if(transform.eulerAngles.z < minRotAngle)
            {
                //move Back
                //Debug.Log(transform.eulerAngles.z);
                //transform.Rotate(0, 0, -rotationSpeed);
                gameObject.GetComponent<Rigidbody2D>().angularVelocity = 1000;

            }
            if(transform.eulerAngles.z < 300)
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
                gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0;
                
                back = true;
            }
        }
	}

    void whichButton()
    {
        if (Input.GetKeyDown("space") && back)
        {
            action = true;
            back = false;
        }
    }
}
