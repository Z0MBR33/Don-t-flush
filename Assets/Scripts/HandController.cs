using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public GameObject root;
    public GameObject handHeight;
    public bool pressed;
    public GameObject objective;
    public bool back;
    public float speed;
    public float distance;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /**
        if (objective.GetComponent<Rigidbody2D>().velocity.y > 0 && objective.transform.position.y - handHeight.transform.position.y > distance)
        {
            root.transform.position = new Vector3(root.transform.position.x, root.transform.position.y + speed, root.transform.position.z);
        }
        **/
        
        if (Input.GetKey("a") && root.transform.position.x > -7.5f)
        {
            root.transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey("d") && root.transform.position.x < 7.5f)
        {
            root.transform.position += new Vector3(speed, 0, 0);
        }
        
        if (Input.GetKey("w"))
        {
            root.transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey("s") && root.transform.position.y > -0.22f)
        {
            root.transform.position += new Vector3(0, -speed, 0);
        }
        
    
    }
}
