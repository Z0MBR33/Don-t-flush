using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCamera : MonoBehaviour
{

    public GameObject ring;

    public GameObject mainCam;

    public GameObject moveCam;
    public GameObject miniCam;
    public int dir;
    public float camSpeed;

    public SpriteRenderer fish;
    public SpriteRenderer mouth;
    public SpriteRenderer eye;
    public SpriteRenderer eyeDamage;

    // public ScriptableObject myScript;

    // Use this for initialization
    void Start()
    {
        
        moveCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = mainCam.GetComponent<Camera>();
        Vector3 proof = camera.WorldToViewportPoint(ring.transform.position);
        Debug.Log("x = " + proof.x + ",  y = " + proof.y);
        if (proof.x <= 1 && proof.x >= -1 && proof.y >= -1 && proof.y <= 1)
        {
            moveCam.SetActive(false);
        }
        else
        {
            moveCam.SetActive(true);
            moveCam.transform.position = new Vector3(ring.transform.position.x, moveCam.transform.position.y, -1);
            //moveCam.transform.position = new Vector3(miniCam.transform.position.x + camSpeed, 0, 0);
        }
    }
}
