using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    Text Highscore;
    int Temp = 0;
    // Use this for initialization
    void Start()
    {
        Highscore = GetComponent<Text>();
        Temp = Score.LoadScore();
        Highscore.text = Temp.ToString();
    }		
}
