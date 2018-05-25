using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public GameObject Blue;
    public GameObject Reb;
    public GameObject Yell;
    // Use this for initialization
    void Start () {
        if (ManagerButton.Select == 1)
        {
            Instantiate(Blue, transform.position, transform.rotation);
        }
        else if (ManagerButton.Select == 2)
        {
            Instantiate(Reb, transform.position, transform.rotation);
        }
        else Instantiate(Yell, transform.position, transform.rotation);
    }
}
