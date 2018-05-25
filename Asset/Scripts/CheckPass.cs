using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPass : MonoBehaviour {

    // Use this for initialization
    public AudioClip Ping;
    public AudioSource audiosoucre;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audiosoucre.PlayOneShot(Ping);
            Score.AddScore();
        }
    }
}
