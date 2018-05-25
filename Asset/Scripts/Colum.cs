using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum : MonoBehaviour {
    public float Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    void Move()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if(transform.position.x <=-13.4)
        {
            Destroy(this.gameObject);
        }
    }
}
