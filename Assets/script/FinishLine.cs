using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
 
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.name == "Player") 
        {
            Debug.Log("hit player");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );

        }
        
    }
}
