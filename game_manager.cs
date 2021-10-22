using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_manager : MonoBehaviour
{
    public float slowDownFactor = 10f;

    public Text hitText;
    public Text restartText;
    public Text ExpText;

    public static bool gamePlays = true;


    void Start(){
        hitText.text = "";
        restartText.text = "";
        ExpText.text = "You're shrunk to the size of atoms. Avoid the falling unstable atoms using W,A,S,D or the arrow keys!";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.fixedDeltaTime * slowDownFactor;
            gamePlays = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Time.timeSinceLevelLoad >= 5)
        {
            ExpText.text = "";
        }
    }


    public void EndGame(){
        gamePlays = false;
        hitText.text = "HIT!";
        restartText.text = "Press 'Space' to play again. Press 'Escape' to quit.";
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel(){
        Time.timeScale = 1f / slowDownFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDownFactor;
        yield return new WaitForSeconds(3f / slowDownFactor);
        
    }



}
