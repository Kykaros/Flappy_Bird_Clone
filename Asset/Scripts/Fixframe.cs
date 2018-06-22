using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixframe : MonoBehaviour {
    // Use this for initialization
    Bounds Temp;
    SpriteRenderer sr;

    bool IsChange = false;
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
        Vector3 TempScale = transform.localScale;

        float Height = sr.bounds.size.y;
        float width = sr.bounds.size.x;

        float WorldHeight = Camera.main.orthographicSize * 2f;//10
        float WorldWidth = WorldHeight * Screen.width / Screen.height;

        TempScale.y = WorldHeight / Height;
        TempScale.x = WorldWidth / width;

        transform.localScale = TempScale;
    }
}
