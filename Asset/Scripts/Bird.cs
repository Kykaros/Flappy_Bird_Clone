using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
    public Rigidbody2D Rig;
    public float Fly = 0f;
    public static bool Death = false;

    public AudioClip Hit, Wing;
    public AudioSource audiosource;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //Rote();
        if(Input.GetMouseButtonUp(0) && transform.position.y <= 4.65)
        {
            Rig.velocity = new Vector2(Rig.velocity.x,Fly);
            if(Manager.FrameGameOver != true)
                audiosource.PlayOneShot(Wing);
        }
        //neu vi tri con chim bay cao hơn dieu kien dat ra thì cho vector van toc ve 0
        if (transform.position.y > 4.65)
        {
            Rig.velocity = new Vector2(0,0);
        }
        if (Rig.velocity.y > 0)
        {
            float angle = 0;
            angle = Mathf.Lerp(0, 90, Rig.velocity.y / 36);
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        else if (Rig.velocity.y == 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Rig.velocity.y < 0)
        {
            float angle = 0;
            angle = Mathf.Lerp(0, -90, -Rig.velocity.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Colum")
        {
            audiosource.PlayOneShot(Hit);
            Death = true;
        }
        else if(collision.gameObject.tag == "Ground")
        {
            audiosource.PlayOneShot(Hit);
            Death = true;
        }
    }
}
