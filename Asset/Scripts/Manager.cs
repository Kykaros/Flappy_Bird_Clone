using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Sprite Gameover;
    public Sprite Startgame;
    bool IsOpen = false;
    public GameObject Again;
    public GameObject score;
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
    }
    void GameOver()
    {
        Time.timeScale = 0;
        this.GetComponent<SpriteRenderer>().sprite = Gameover;
        Again.SetActive(true);
        score.SetActive(true);
        Bird.Death = false;
    }
    void StartGame()
    {
        Time.timeScale = 0;
        this.GetComponent<SpriteRenderer>().sprite = Startgame;
    }
}
