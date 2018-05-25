using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBackGround : MonoBehaviour {
    public float Speed = 5f;
    public Vector3 StartPosition;
	// Use this for initialization
	void Start () {
        StartPosition = transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if(transform.position.x <= -12.45)
        {
            transform.position = StartPosition;
        }
	}
}
