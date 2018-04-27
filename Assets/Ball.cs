using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 forceVector;
    float horitzonalForce = 0; 
    float vectoralForce=0;
    float _FORCEPOWER = 25;
    Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    { 
        //init
        forceVector = new Vector3() ;
        horitzonalForce = 0;
        vectoralForce = 0;
         
        //get force essentials
        if (Input.GetKey(KeyCode.LeftArrow))
            vectoralForce = -_FORCEPOWER;
        if (Input.GetKey(KeyCode.RightArrow))
            vectoralForce = _FORCEPOWER;
        if (Input.GetKey(KeyCode.UpArrow))
            horitzonalForce = _FORCEPOWER;
        if (Input.GetKey(KeyCode.DownArrow))
            horitzonalForce = -_FORCEPOWER;


        //force calculations
        //yeni hali vektöre ekle
        forceVector.x = vectoralForce;
        forceVector.z = horitzonalForce;
        //uçur bizi spagettin
        rb.AddForce(forceVector, ForceMode.VelocityChange);
    }

}
