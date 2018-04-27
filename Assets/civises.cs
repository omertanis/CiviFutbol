using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class civises : MonoBehaviour {
	AudioSource audio1;
    public GameObject Coin;
    public Toggle toggle;
	// Use this for initialization
	void Start () {
		audio1 = GetComponent<AudioSource> ();
	}
	

	void OnCollisionEnter()
	{
        if (toggle.isOn)
        {
            audio1.Play();
        }
    }
}
