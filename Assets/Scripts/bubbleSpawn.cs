using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleSpawn : MonoBehaviour {
    public GameObject myBubble;
    private GameObject temp;
    public GameObject rootPoint;

    float min = -14;
    float max = 14f;
    private float counter = 0;

    void Start() {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (rootPoint.transform.position.y > 30)
        {
            Destroy(collision.gameObject);
        }
    }

        void Update() {
        if (rootPoint.transform.position.y > 10 && rootPoint.transform.position.y < 70)
        {
            counter += 0.03f;
            float ran = Random.Range(min, max);

            temp = myBubble;
           
            temp.transform.position = new Vector3(ran, transform.position.y, 0);

            if (counter >= 200)
            {
                Instantiate(myBubble);
                counter = 0;
            }

        }
        

    }


}
