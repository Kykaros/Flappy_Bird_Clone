using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public Sprite[] ArrNumbers;
    public Transform Parent;
    public static  int Point = 0;
    int HangChuc = 0;
    int HangDV = 0;
    int HangTram = 0;
    int Temp = 0;
	// Use this for initialization
	void Start () {
        ResetScore();
        for (int i = 1; i<3 ; i++)
        {
            Parent.GetChild(i).GetComponent<SpriteRenderer>().sprite = null;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(Point < 10)
        {
            Parent.GetChild(0).GetComponent<SpriteRenderer>().sprite = ArrNumbers[Point];
        }
        else if(Point >= 10 && Point < 100)
        {
            Temp = Point;
            HangDV = Temp % 10;
            HangChuc = Temp / 10;
            Parent.GetChild(0).GetComponent<SpriteRenderer>().sprite = ArrNumbers[HangDV];
            Parent.GetChild(1).GetComponent<SpriteRenderer>().sprite = ArrNumbers[HangChuc];
        }
        else
        {
            Temp = Point;
            HangDV = Temp % 10;
            HangChuc = TachSo(ref Temp);
            Debug.Log(Temp);
            HangTram = TachSo(ref Temp);
            Parent.GetChild(0).GetComponent<SpriteRenderer>().sprite = ArrNumbers[HangDV];
            Parent.GetChild(1).GetComponent<SpriteRenderer>().sprite = ArrNumbers[HangChuc];
            Parent.GetChild(2).GetComponent<SpriteRenderer>().sprite = ArrNumbers[HangTram];
        }
	}
    int TachSo(ref int num)
    {
        num /= 10;
        return num % 10;
    }
    public static int AddScore()
    {
        return Point++;
    }
    void ResetScore()
    {
        Point = 0;
    }
    public static void SaveScore()
    {
        int Temp = PlayerPrefs.GetInt("Player");
        if(Point > Temp)
        {
            PlayerPrefs.SetInt("Player", Point);
            PlayerPrefs.Save();
        }
    }
    public static int LoadScore()
    {
        return PlayerPrefs.GetInt("Player");
    }
}
