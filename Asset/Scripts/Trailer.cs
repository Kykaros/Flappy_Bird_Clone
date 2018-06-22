using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Trailer : MonoBehaviour {

    // Use this for initialization
    double time;
    double currtime;
    void Start()
    {
        time = GetComponent<VideoPlayer>().clip.length;
        Debug.Log(time);
    }
    void Update()
    {
        currtime = gameObject.GetComponent<VideoPlayer>().time;
        Debug.Log(currtime);
        if (currtime >= time)
            SceneManager.LoadScene(1);
    }
}
