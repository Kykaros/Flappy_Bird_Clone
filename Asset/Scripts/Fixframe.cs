using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixframe : MonoBehaviour {
    // Use this for initialization
    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ChangeFrame();
    }
    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
        else if (Input.deviceOrientation == DeviceOrientation.LandscapeRight)
            Screen.orientation = ScreenOrientation.LandscapeRight;
    }
    void ChangeFrame()
    {
        //lay localscale hien tai cua frame
        Vector3 TempScale = transform.localScale;

        //lay chieu cao cua hinh
        float Height = sr.bounds.size.y;

        //lay chieu ngang cua hinh
        float width = sr.bounds.size.x;

        //size camera x2
        float WorldHeight = Camera.main.orthographicSize * 2f;//10
        
        float WorldWidth = WorldHeight * Screen.width / Screen.height;

        TempScale.y = WorldHeight / Height;
        TempScale.x = WorldWidth / width;

        transform.localScale = TempScale;
    }
}
