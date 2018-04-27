using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Directional Lighting Rotation Must be set To 0,0,0
/// </summary>
public class SunMovement : MonoBehaviour {

    public float rotateX;
    private int switchFrame;
    private bool isXPositive;


    // Use this for initialization
    void Start () {
        isXPositive = true;
        switchFrame = 180;
    }
	// Update is called once per frame
	void Update () {
        rotateLighting();
	}
    int x = 0;
    void rotateLighting()
    {
        if(x%switchFrame == 0)
        {
            isXPositive = !isXPositive;
            x = 0;
        }
        if (isXPositive)
        {
            transform.Rotate(rotateX, 0, 0);
        }
        else
        {
            transform.Rotate(-rotateX, 0, 0);
        }
        x++;
    }
}
