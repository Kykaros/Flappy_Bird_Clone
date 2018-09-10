using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject Win;
    public Sprite Gameover;
    public Sprite Startgame;
    bool IsOpen = false;
    public static bool FrameGameOver = false;
    public GameObject Again;
    public GameObject score;
    public GameObject DisplayScore;
    int ChangeState = 5;
    // Use this for initialization
    void Start()
    {
        StartGame();
        Win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && IsOpen == false)
        {
            Time.timeScale = 1;
            this.GetComponent<SpriteRenderer>().sprite = null;
            DisplayScore.SetActive(true);
            IsOpen = true;
        }
        if (Bird.Death == true)
        {
            //chuyen scene gameover
            GameOver();
            //luu diem
            Score.SaveScore();
        }
        if(Score.Point == 999)
        {
            //win
            Win.SetActive(true);
        }
    }
    void GameOver()
    {
        Time.timeScale = 0;
        this.GetComponent<SpriteRenderer>().sprite = Gameover;
        Again.SetActive(true);
        score.SetActive(true);
        FrameGameOver = true;
    }
    void StartGame()
    {
        Time.timeScale = 0;
        this.GetComponent<SpriteRenderer>().sprite = Startgame;
    }
}
