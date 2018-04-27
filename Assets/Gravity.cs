using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = (Rigidbody)(gameObject.GetComponent<Rigidbody>());
    }

    // Update is called once per frame
    // F = m.a , acceleration is equal with gravity so, f is downforce
    void Update()
    {
        //Bugfix for developers
        if(rb is Rigidbody && rb != null)
            rb.AddForce(Physics.gravity * rb.mass);
    }
}
