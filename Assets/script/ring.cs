using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{
    public float turnRate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "vertical")
        {
            transform.Rotate(turnRate * Time.deltaTime, 0f, 0f, Space.Self);
            //transform.Rotate(0f, -direction * turnRate * Time.deltaTime, 0f, Space.Self);
        }
        else { 
            transform.Rotate(0f, turnRate * Time.deltaTime, 0f, Space.Self); 
        }
    }
}
