using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartButton() {
        //restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("restart");
    }

    public void HomeButton() {
        SceneManager.LoadScene("MainScreen");
        Debug.Log("MainScreen");
    }
}
