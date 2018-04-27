using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buton : MonoBehaviour {

    // Use this for initialization
    public void start(int sahneNo)
    {
        Application.LoadLevel(sahneNo);
    }
    public void exit()
    {
        Application.Quit();
    }
    
	
	
}
