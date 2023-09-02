using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class collider : MonoBehaviour

{
   

    public GameObject explodeGamer;
    void OnTriggerEnter(Collider collideInfo)
    {
    
        if (collideInfo.gameObject.tag == "enemy")
        {


           // Debug.Log(gameObject.GetComponent<MeshRenderer>().material.ToString() + " collide with " + collideInfo.gameObject.GetComponent<MeshRenderer>().material.ToString());


            if (collideInfo.gameObject.GetComponent<MeshRenderer>().material.GetColor("_Color") != GetComponent<MeshRenderer>().material.GetColor("_Color")) {
                //Debug.Log("explode");

                GameObject.Instantiate(explodeGamer,transform.position,Quaternion.identity);
                Destroy(gameObject);
                //set speed to 0
                transform.GetComponentInParent<PathFollower>().Playerdied = true;


            }
        }
    }
}