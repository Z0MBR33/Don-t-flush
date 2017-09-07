using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer3 : MonoBehaviour
{

    public bool init;
    public Text timerText;
    private float startTime;


    //public bool isImgOn;


    // Use this for initialization
    void Start()
    {

        init = true;
        //isImgOn = true;

    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "test")
        {
            if (init == true)
            {
                startTime = Time.time;
                init = false;
            }

            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            float countDown = 31 - t;
            string countingDown = countDown.ToString("f2");

            timerText.text = countingDown;

            if (countDown < 27)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

}


