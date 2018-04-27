using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    public GameObject panel;
    

    
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	public void pause() {
        panel.gameObject.SetActive(true); 
         
    }

    public void contiune()
    {
        panel.gameObject.SetActive(false);
        
        
    }

    public void restart(int scene)
    {
        Application.LoadLevel(scene);
    }

    public void exit(int scene)
    {
        Application.LoadLevel(scene);
    }
}
