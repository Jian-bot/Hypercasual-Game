using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cross : MonoBehaviour
{
    public float turnRate;
    public float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (gameObject.name == "cross_l"|| gameObject.name == "dr_l")
        {
            transform.Rotate(0f, -direction * turnRate * Time.deltaTime, 0f, Space.Self);
        }
        else {
            transform.Rotate(0f, direction * turnRate * Time.deltaTime, 0f, Space.Self);
        }*/

        transform.Rotate(0f, direction * turnRate * Time.deltaTime, 0f, Space.Self);

    }
}
