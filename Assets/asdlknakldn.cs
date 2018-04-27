using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdlknakldn : MonoBehaviour {
    public GameObject panel;
    bool x;

    // Use this for initialization
    void Start () {
        x = false;

	}
    public void pause()
    {
        x = true;

    }

    // Update is called once per frame
    void Update () {
        if (x == true)
        {
            panel.gameObject.SetActive(true);
            x = false;
        }
		
	}
}
