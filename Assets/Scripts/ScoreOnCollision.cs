using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnCollision : MonoBehaviour {
    public GameObject ring;
    public ScriptableObject myFish;
    public ScriptableObject myBubble;
    public int scoreValueFish = 10;
    public int scoreValueBubble = 5;


    public GUIText scoreText;

    private int score;

    void OnCollisionEnter2D(Collision2D collision)
    {
        string colisionsName = collision.gameObject.name.ToString();
        GameObject myBubble = collision.gameObject;

        if (collision.gameObject.tag.Equals("fish"))
        {
            if (collision.gameObject.GetComponent<Fish>().damage())
            {
                score += collision.gameObject.GetComponent<Fish>().scoreValue;
                
            }
        }
    
        if (collision.gameObject.tag.Equals("bubble"))
        {
            Destroy(collision.gameObject);
            score += collision.gameObject.GetComponent<bubbles>().scoreValue;
        }
    }

    void UpdateScore()
    {
       scoreText.text = "Score: " + score;
       
    }

    void Update () {
        
    }
}
