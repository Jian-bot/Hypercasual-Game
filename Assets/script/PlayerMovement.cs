using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float SidewaysBound = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        //transform.position = new Vector3(Input.mousePosition.x, transform.position.y, transform.position.z);
        //right click to pause
        float xPos = Mathf.Lerp(-SidewaysBound, SidewaysBound, Input.mousePosition.x / Screen.width);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

    }
}
