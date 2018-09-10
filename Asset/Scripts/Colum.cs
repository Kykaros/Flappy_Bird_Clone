using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum : MonoBehaviour {
    public float Speed;
    bool MaxUp = false;
    int Choice;
	// Use this for initialization
	void Start () {
        Choice = RanD();
    }
	
	// Update is called once per frame
	void Update () {
        Move();
        ChoiceState(Choice);
        //ChangeStateUpAndDown();
    }
    void Move()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if(transform.position.x <=-21)
        {
            Destroy(this.gameObject);
        }
    }
    void ChangeStateUpAndDown()
    {
        if (transform.position.y < -1.16 && MaxUp == false)
        {
            transform.Translate(Vector3.up * 2f * Time.deltaTime);
            if(transform.position.y >= -1.16)
                MaxUp = true;
        }
        else if (transform.position.y > -5.4 && MaxUp == true)
        {
            transform.Translate(Vector3.down * 2f * Time.deltaTime);
            if(transform.position.y <= -5.4)
                MaxUp = false;
        }
    }
    void ChangeStateDown()
    {
        if (transform.position.y >= -5.4)
        {
            transform.Translate(Vector3.down * 1f * Time.deltaTime);
        }
    }
    void ChangeStateUp()
    {
        if (transform.position.y <= -1.16)
        {
            transform.Translate(Vector3.up * 1f * Time.deltaTime);
        }
    }
    void ChoiceState(int c)
    {
       switch(c)
        {
            case 0: ChangeStateDown(); break;
            case 1: ChangeStateUpAndDown(); break;
            case 2: ChangeStateUp(); break;
        }
    }
    int RanD()
    {
        int r = Random.Range(0, 3);
        return r;
    }
}
