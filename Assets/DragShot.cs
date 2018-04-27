using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragShot : MonoBehaviour {

    //Dragshooting variables
    private Vector3 downPosition, upPosition;
    private Rigidbody rb;
    /// <summary>
    /// Limit of Coin Speed
    /// </summary>
    public float coinSpeedLimit;
    /// <summary>
    /// Force per Dragging
    /// </summary>
    public float forceMultiper;
    /// <summary>
    /// TEST AMAÇLI
    /// </summary>
    public float trollDondur;
    /// <summary>
    /// Durdumra menüsünün paneli
    /// </summary>
    public GameObject pauseMenu;
    private float tempLimit;

    /// <summary>
    /// En düşük çekme gücü
    /// </summary>
    public float minimumForceToPlay;

    public Text solsıra;
    public Text sagsıra;

    // Use this for initialization
    void Start ()
    {
        downPosition = new Vector3();
        upPosition = new Vector3();
        rb = (Rigidbody)gameObject.GetComponent<Rigidbody>();
    }
	// Update is called once per frame
	void Update ()
    {

       if (solsıra.gameObject.activeSelf.Equals(true) && sagsıra.gameObject.activeSelf.Equals(true))
        {
            sagsıra.gameObject.SetActive(false);
        }

        //If left key down.
        if (Input.GetMouseButtonDown(0))
            {
                //Get mouse hold location first.
                downPosition = Input.mousePosition;
                //DEBUGGING hataYaz("Down point : X=" + Input.mousePosition.x + " Y =" + Input.mousePosition.y + " Z=" + Input.mousePosition.z);
            }
            //If key released.
            else if (Input.GetMouseButtonUp(0))
            {
            upPosition = Input.mousePosition;
                //DEBUGGING hataYaz("Release point : X=" + Input.mousePosition.x + " Y =" + Input.mousePosition.y + " Z=" + Input.mousePosition.z);
                //Shoots the object which has got this script.
                if(!pauseMenu.activeSelf) //Bugfix for menu
                Shoot();
            }
            //if key held
            else if (Input.GetMouseButton(0))
            {
                //Draw the aiming of object by mousedown and current location
                drawAiming();
                transform.Rotate(new Vector3(0, Random.value * trollDondur, 0));
            }
	}

    /// <summary>
    /// This function works with global down-up position variables. Calculating difference and adding force to object by difference
    /// WE'LL ADD LIMIT FOR DRAGGING SOON !!
    /// </summary>
    private void Shoot()
    {
        //clear trajectory
        var line = gameObject.GetComponent<LineRenderer>();
        line.SetPosition(0, new Vector3(0, 0, 0));
        line.SetPosition(1, new Vector3(0, 0, 0));

        //DEBUGGING hataYaz("Shoot fonk girdi");
        Vector3 objectCenter = rb.position;

        //Calculating angle & length
        Vector3 powerVector = downPosition - upPosition;
        //Distance with limit of 200
        float distance = Vector3.Distance(downPosition, upPosition) > coinSpeedLimit ? coinSpeedLimit : Vector3.Distance(downPosition, upPosition);
        //Mouse location gets X-Y from screen. But we'll add X and Z for game. Thanks to camera bird view
        powerVector.z = powerVector.y;
        powerVector.y = 0;

        // hataYaz(powerVector.ToString()+ " power "+ distance);
        // güc = SQRT(x^2 + y^2)
        //Düşük hız kontrol etme
        if (distance < minimumForceToPlay)
            return;

        //Rigidbody of gameObject
        rb = (Rigidbody) gameObject.GetComponent<Rigidbody>();
        //Force adding. FORMULA IS in SUMMARY
        rb.AddForce(powerVector * distance * forceMultiper,ForceMode.Force);
        //DEBUGGING hataYaz("Force eklendi");

        if (solsıra.gameObject.activeSelf.Equals(true))
        {
            solsıra.gameObject.SetActive(false);
            sagsıra.gameObject.SetActive(true);
        }
        else if (sagsıra.gameObject.activeSelf.Equals(true))
        {
            sagsıra.gameObject.SetActive(false);
            solsıra.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// Aiming trajectory drawer
    /// </summary>
    private void drawAiming()
    {
        //get linerenderer
        var line = gameObject.GetComponent<LineRenderer>();
        //start-endpoint calculations
        Vector3 startPoint = new Vector3();
        Vector3 endPoint = new Vector3();
        float _y = 1.5f;
        //startpoint calculations
        startPoint.x = transform.position.x;
        startPoint.z = transform.position.z;
        startPoint.y = _y;

        //endpoint calculations
        endPoint.x = transform.position.x + (downPosition.x - Input.mousePosition.x)/10;
        endPoint.z = transform.position.z + (downPosition.y - Input.mousePosition.y)/10;
        endPoint.y = _y;

        //adding start-endpoint for drawer
        line.SetPosition(0, startPoint);
        line.SetPosition(1, endPoint);

        if (solsıra.gameObject.activeSelf.Equals(true))
        {
            line.SetColors(Color.red, Color.yellow);
        }
        else if (sagsıra.gameObject.activeSelf.Equals(true))
        {
            line.SetColors(Color.blue, Color.green);
        }
    }


    //Unit testing
    private void hataYaz(string message)
    {
        Debug.Log(message);
    }

}
