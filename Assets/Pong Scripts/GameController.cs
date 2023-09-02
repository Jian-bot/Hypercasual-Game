using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject ball;
    public Text scoreTextLeft;
    public Text scoreTextRight;
    public Starter starter;

    private bool started = false;
    private int scoreLeft = 0;
    private int scoreRight = 0;
    private BallController ballController;
    private Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        this.ballController = this.ball.GetComponent<BallController>();
        this.startingPosition = this.ball.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        
        if(!started && Input.GetKey(KeyCode.Space)){
            this.started = true;
            this.starter.StartCountdown();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainUI");
        }
    } 

    //240th frame the ball is released
    public void StartGame(){
        this.ballController.Go();
    }

    //adding score and callign the UI update function for left and right
    public void ScoreGoalLeft(){
        Debug.Log("Scored Left");
        this.scoreRight += 1;
        UpdateUI();
        ResetBall();
    }
    
    public void ScoreGoalRight(){
        Debug.Log("Scored Right");
        this.scoreLeft += 1;
        UpdateUI();
        ResetBall();
    }

    //updates the int value to string to change text
    public void UpdateUI(){
        this.scoreTextLeft.text = this.scoreLeft.ToString();
        this.scoreTextRight.text = this.scoreRight.ToString();
    }

    private void ResetBall(){
        this.ballController.Stop();
        this.ball.transform.position = this.startingPosition;
        this.starter.StartCountdown();
    }
}
