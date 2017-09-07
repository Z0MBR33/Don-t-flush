using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

    public Button startText;
    public Button credits;
    public Button leaveCredits;
    public Canvas CreditCanvas;

    void Start() {
        startText = startText.GetComponent<Button>();
        credits = credits.GetComponent<Button>();
        leaveCredits = leaveCredits.GetComponent<Button>();


        CreditCanvas = CreditCanvas.GetComponent<Canvas>();

        CreditCanvas.enabled = true;
    }

    public void StartLevel (){
        SceneManager.LoadScene("test");
        }


    public void creditsPress()
    {
        CreditCanvas.enabled = false;
    }

    public void leaveCreditsPress()
    {
        SceneManager.LoadScene("startScreen");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
