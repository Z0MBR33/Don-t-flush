using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer3 : MonoBehaviour {


    public Text timerText;
    private float startTime;


    public bool isImgOn;
    public Image timeRanOut;


    // Use this for initialization
    void Start () {

        timeRanOut.enabled = true;
        isImgOn = true;

        startTime = Time.time;
        float u = 100;
	}
	
	// Update is called once per frame
	void Update () {





        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        


        float countDown = 30 - t;
        string countingDown = countDown.ToString("f2");


        timerText.text = countingDown;

        if (countDown  < 27)
        {
            SceneManager.LoadScene(2);

        }
    }
}
