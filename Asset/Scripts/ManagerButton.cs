using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class ManagerButton : MonoBehaviour {
    bool IsClick = false;
    public static int Select = 1;
    public GameObject TextPause;    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            BackButton();
    }
    public void ChangeScene(string Name)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Name);
        Manager.FrameGameOver = false;
        Bird.Death = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Pause()
    {
        if(Bird.Death == false && Manager.FrameGameOver == false)
        {
            if (IsClick == false)
            {
                Time.timeScale = 0;
                TextPause.SetActive(true);
                IsClick = true;
            }
            else
            {
                Time.timeScale = 1;
                TextPause.SetActive(false);
                IsClick = false;
            }
        }
    }
    public void SelectBird(int number)
    {
        Select = number;
    }
    void BackButton()
    {
        Application.Quit();
    }

    public void Skip()
    {
        SceneManager.LoadScene(1);
    }
}
