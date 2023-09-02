using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    public float minDirection = 0.5f;

    private Vector3 direction;
    private Rigidbody rb;
    private bool stopped = true;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //method1
        //transform.position += direction * speed * Time.deltaTime;
    }
    void FixedUpdate()
    {
        if(stopped){
            return;
        }
        //causes ball to start in a position
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }

    //function to react with colliders
    private void OnTriggerEnter(Collider other){
        //bounce ball off wall
        if(other.CompareTag("Wall")){
            direction.z = -direction.z;
        }

        //change direction of ball to react to paddle position
        if(other.CompareTag("Racket")){
            Vector3 newDirection = (transform.position - other.transform.position).normalized;

            newDirection.x = Mathf.Sign(newDirection.x) * Mathf.Max(Mathf.Abs(newDirection.x), this.minDirection);
            newDirection.z = Mathf.Sign(newDirection.z) * Mathf.Max(Mathf.Abs(newDirection.z), this.minDirection);

            direction = newDirection;
        }
    }

    //change direction from start
    private void ChooseDirection(){
        float signX = Mathf.Sign(Random.Range(-1f, 1f));
        float signZ = Mathf.Sign(Random.Range(-1f, 1f));

        this.direction = new Vector3(0.5f * signX, 0 , 0.5f * signZ);
    }

    //stop ball for reset
    public void Stop(){
        this.stopped = true;
    } 

    //send ball after reset
    public void Go(){
        ChooseDirection();
        this.stopped = false;
    }
}
