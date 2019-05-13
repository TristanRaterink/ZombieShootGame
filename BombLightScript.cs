using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLightScript : MonoBehaviour {

    Light myLight;
    float timer;
    public AudioClip bombSound;
    AudioSource bomb;



    // Use this for initialization
    void Start () {
        myLight = GetComponent<Light>();
        bomb = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        if (ScoreManager.score > 500 && Input.GetKeyDown(KeyCode.B))
        {

            myLight.enabled = true;
            bomb.clip = bombSound;
            bomb.Play();

        } else { 
            myLight.enabled = false;

            
        }
        
        }
}
