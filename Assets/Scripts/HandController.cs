using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject root;
    public bool pressed;
    public bool back;
    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a"))
        {
            root.transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            root.transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            root.transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey("s"))
        {
            root.transform.position += new Vector3(0, -speed, 0);
        }
    }
}



/**
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






    if (Input.GetKeyDown("space") && !pressed)
        {
            leftHand.GetComponent<HingeJoint2D>().useMotor = true;
            rightHand.GetComponent<HingeJoint2D>().useMotor = true;
            pressed = true;
        }

        if (leftHand.GetComponent<HingeJoint2D>().jointAngle <= 70 && rightHand.GetComponent<HingeJoint2D>().jointAngle >= 70 && pressed)
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
        **/
