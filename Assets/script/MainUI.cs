using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;//for the buttons


public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void ColorSwitch()
    {
        SceneManager.LoadScene("MainScreen");
        //Debug.Log("Home Start level_0");
    }
    public void Pong()
    {
        SceneManager.LoadScene("Pong");
        //Debug.Log("Home Start level_0");
    }
    public void Mainquit()
    {
        Debug.Log("quit game");
        Application.Quit();
        
    }

}
