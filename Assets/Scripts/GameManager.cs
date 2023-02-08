﻿using UnityEngine;
using UnityEngine.SceneManagement; // cand vrem sa ne jucam cu scenele(trecem de la una la alta, le restartam)

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    

    public void CompleteLevel()
    {
        //  Debug.Log("Level WON");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");

            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}