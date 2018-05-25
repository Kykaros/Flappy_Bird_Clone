using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColum : MonoBehaviour {
    public GameObject Colum;
    public float Time;
    public float Repeatrate;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", Time, Repeatrate);
	}
	
	// Update is called once per frame
    void Spawn()
    {

        Instantiate(Colum,new Vector3(transform.position.x,random(),0), transform.rotation);
    }
    float random()
    {
        float Y = Random.Range(-4.2f, -1.3f);
        return Y;
    }
}
