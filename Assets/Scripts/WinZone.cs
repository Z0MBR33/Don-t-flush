using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinZone : MonoBehaviour {
    public GameObject ring;

	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if ( ring.Equals(collision.gameObject))
        {
            SceneManager.LoadScene(4);

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
