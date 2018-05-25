using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerButton : MonoBehaviour {
    bool IsClick = false;
    public static int Select = 1;
    public void ChangeScene(string Name)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Name);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Pause()
    {
        if (IsClick == false)
        {
            Time.timeScale = 0;
            IsClick = true;
        }
        else
        {
            Time.timeScale = 1;
            IsClick = false;
        }
    }
    public void SelectBird(int number)
    {
        Select = number;
    }
}
