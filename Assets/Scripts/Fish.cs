using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {
    public float rightPosition;
    public float leftPosition; // 
    public float speed;
    public int backgroundLayer;
    public int forgroundLayer;
    public bool isDead;
    public GameObject deadBody;

    private int currentDirection;
    private float currentPositionX;
    private GameObject myObject;

    private int live;

    public int scoreValue = 10;

    public SpriteRenderer fish;
    public SpriteRenderer mouth;
    public SpriteRenderer eye;
    public SpriteRenderer eyeDamage;

    // Use this for initialization
    void Start () {
        myObject = gameObject;//GetComponent<GameObject>();
        //leftPosition = myObject.transform.position.x;
        currentDirection = -1;
        live = 2;
	}
	
	// Update is called once per frame
	void Update () {
        if(!isDead){
            currentPositionX = myObject.transform.transform.position.x;
            if (currentPositionX <= leftPosition || currentPositionX >= rightPosition)
            {
                currentDirection = currentDirection * -1;
                changeLayer();
                myObject.transform.localScale = new Vector3(-currentDirection,1,1);
            }

            myObject.transform.position += new Vector3(speed * currentDirection,0,0);
        }
        if (isDead)
        {
            
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
	}

    public bool damage()
    {
        live -= 1;
        if(live <= 0)
        {
            fish.enabled = false;
            mouth.enabled = false;
            eye.enabled = false;
            deadBody.SetActive(true);
            isDead = true;
            return true;
        }
        else { return false; }
        
    }

    public void changeLayer()
    {
        if (currentDirection == -1)
        {
            fish.sortingOrder = 11;
            mouth.sortingOrder = 12;
            eye.sortingOrder = 12;
            //GetComponent<Collider2D>().enabled = true;
        }
        if (currentDirection == 1)
        {
            fish.sortingOrder = 4;
            mouth.sortingOrder = 5;
            eye.sortingOrder = 5;
            //GetComponent<Collider2D>().enabled = false;
        }

    }
}
