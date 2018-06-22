using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Sprite Gameover;
    public Sprite Startgame;
    bool IsOpen = false;
    public static bool FrameGameOver = false;
    public GameObject Again;
    public GameObject score;
    int ChangeState = 5;
    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && IsOpen == false)
        {
            Time.timeScale = 1;
            this.GetComponent<SpriteRenderer>().sprite = null;
            IsOpen = true;
        }
        if (Bird.Death == true)
        {
            //chuyen scene gameover
            GameOver();
            //luu diem
            Score.SaveScore();
        }
        if(Score.Point == ChangeState)
        {
            //SpawnColum.SetRepeatTime(SpawnColum.RepeatTime - 0.5f);
            //ChangeState += 5;
            //Debug.Log(ChangeState);
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
