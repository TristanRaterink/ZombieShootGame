using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AtomBombScript : MonoBehaviour
{
    public static int score;
    public bool isReady;
    Color color;


    Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();
        isReady = false;

        // Reset the score.
       
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.

        if(ScoreManager.score > 500){
            isReady = true;
            text.text = "READY";
            text.color = Color.green;
        } else {
            text.text = "NOT READY";
            text.color = Color.red;

        }
     
    }
}
