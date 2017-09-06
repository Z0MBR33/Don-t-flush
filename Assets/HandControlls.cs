using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControlls : MonoBehaviour {

    public GameObject leftHand;
    public GameObject rightHand;
    public Quaternion rotationEndL;
    public Quaternion rotationEndR;
    public float speed;

    public Quaternion rotationBeginL;
    public Quaternion rotationBeginR;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //leftHand.transform.Rotate(Vector3.forward * Time.deltaTime * 3000);
            //leftHand.transform.rotation = Quaternion.Slerp(rotationBeginL, rotationEndL-45, Time.time * speed);
            //transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion.Euler(transform.rotation.x, 345f, tramsform.rotation.z), Time.deltaTime * speed);
        }
    }
}
