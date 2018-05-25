using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixframe : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 TempScale = transform.localScale;

        float Height = sr.bounds.size.y;
        float width = sr.bounds.size.x;

        float WorldHeight = Camera.main.orthographicSize * 2f;//10
        float WorldWidth = WorldHeight * Screen.width / Screen.height;

        TempScale.y = WorldHeight/Height;
        TempScale.x = WorldWidth/width;

        transform.localScale = TempScale;
	}	
}
