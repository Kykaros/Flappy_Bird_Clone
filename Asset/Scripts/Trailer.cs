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
        //lay do dai cua vid
        time = GetComponent<VideoPlayer>().clip.length;
    }
    void Update()
    {
        //lay thoi gian hien tai cua video
        currtime = gameObject.GetComponent<VideoPlayer>().time;
        if (currtime >= time)
            SceneManager.LoadScene(1);
    }
}
