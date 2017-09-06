using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {
	public GameObject leftHand;
    public GameObject rightHand;
    public bool pressed;
    public bool back;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && !pressed)
        {
            leftHand.GetComponent<HingeJoint2D>().useMotor = true;
            rightHand.GetComponent<HingeJoint2D>().useMotor = true;
            pressed = true;
        }
        
        if (leftHand.GetComponent<HingeJoint2D>().jointAngle <= -70 && rightHand.GetComponent<HingeJoint2D>().jointAngle >= 70 && pressed)
        {
            leftHand.GetComponent<HingeJoint2D>().useMotor = false;
            rightHand.GetComponent<HingeJoint2D>().useMotor = false;
            back = true;
            
        }
        if (leftHand.GetComponent<HingeJoint2D>().jointAngle >= -20 && rightHand.GetComponent<HingeJoint2D>().jointAngle <= 20 && back)
        {
            Debug.Log("hi");
            pressed = false;
            back = false;
        }

    }
}
