using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColum : MonoBehaviour {
    public GameObject[] ArrCol;
    public static float TimeStart = 2f;
    public static float RepeatTime = 2.5f;
	// Use this for initialization
    public static void SetTime(float time)
    {
        TimeStart = time;
    }
    public static void SetRepeatTime(float time)
    {
        RepeatTime = time;
    }
    void Start () {
        InvokeRepeating("Spawn", TimeStart, RepeatTime);
	}

    // Update is called once per frame
    void Spawn()
    {
        if (Score.Point < 20)
        {
            Instantiate(ArrCol[0], new Vector3(transform.position.x, random(), 0), transform.rotation);
        }
        else if (Score.Point >= 20 && Score.Point < 40)
        {
            Instantiate(ArrCol[1], new Vector3(transform.position.x, random(), 0), transform.rotation);
        }
        else if (Score.Point >= 40 && Score.Point < 60)
        {
            Instantiate(ArrCol[1], new Vector3(transform.position.x, random(), 0), transform.rotation);
        }
        else if( Score.Point >=60 && Score.Point <80)
        {
            Instantiate(ArrCol[1], new Vector3(transform.position.x, random(), 0), transform.rotation);
        }
        else
        {
            Instantiate(ArrCol[1], new Vector3(transform.position.x, random(), 0), transform.rotation);
        }
    }

    float random()
    {
        float Y = Random.Range(-4.2f, -1.3f);
        return Y;
    }
}
