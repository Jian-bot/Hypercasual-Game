using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;//for the buttons

public class HomeScreen : MonoBehaviour
{
   
    public void HomeStart()
    {
        SceneManager.LoadScene("level_0");
        //Debug.Log("Home Start level_0");
    }
    public void backTo3Game(){

        //add the main UI to load the scene with three games
        SceneManager.LoadScene("MainUI");
    }

    public void selectLevels()
    {     
        string level = EventSystem.current.currentSelectedGameObject.name;
        //Debug.Log(level);
        SceneManager.LoadScene("level_"+level);
    }

    public void Gamequit()
    {
        Application.Quit();
        Debug.Log("end");
    }

}
