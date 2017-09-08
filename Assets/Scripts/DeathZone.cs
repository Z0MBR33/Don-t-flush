using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour {
    public GameObject ring;

	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("tot");

        if ( ring.Equals(collision.gameObject))
        {
            Destroy(ring);
            SceneManager.LoadScene("startscreen");
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
