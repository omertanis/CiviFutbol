using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class sagSkor : MonoBehaviour {

    public ScoreUI score;
    public bool isRightPlayer;
    public string playerName;
    public Text txt;
    // Use this for initialization
    void Start () {
        txt = gameObject.GetComponent<Text>();
        if (playerName.TrimEnd(' ').TrimStart(' ').Length==0)
            playerName = "Player";

    }
	
	// Update is called once per frame
	void Update () {
        if(isRightPlayer)
        {
            txt.text =""+score.scorePlayerRight;
        }
        else
        {
            txt.text =""+score.scorePlayerLeft;
        }
        

    }
}
