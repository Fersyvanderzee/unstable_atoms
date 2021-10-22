using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_score : MonoBehaviour
{
    public float score = 0f;
    public Text scoreText;

    void Update(){
        if (game_manager.gamePlays)
        {
            scoreText.text = "Score: " + score.ToString("f0");
        }
        

    }
}
