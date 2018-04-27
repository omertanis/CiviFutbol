using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// This behaviour should only exists once in the level and can be attached to any GameObject.
/// It displays the score at the top center of the sreen.
/// </summary>
public class ScoreUI : MonoBehaviour {
	
	/// <summary>
	/// Current score of the right player.
	/// </summary>
	public int scorePlayerRight;
	/// <summary>
	/// Current score of the left player.
	/// </summary>
	public int scorePlayerLeft;
	/// <summary>
	/// Style that is used to display the score text.
	/// </summary>
	public GUIStyle style;

    int solskor, sagskor;

	/// <summary>
	/// Score that must be reached, to win the game.
	/// </summary>
	public int winningScore = 5;

    public GameObject cnv;
    public Text solTxt;
    public Text sagTxt;
    public Text win;

    public Text sagsıra;
    public Text solsıra;

    void OnGUI()
	{
         if(scorePlayerLeft == 0 && scorePlayerRight == 0)
        {
            solskor = scorePlayerLeft;
            sagskor = scorePlayerRight;
        }
        if(scorePlayerLeft > solskor)
        {
            solsıra.gameObject.SetActive(false);
            sagsıra.gameObject.SetActive(true);
            solskor = scorePlayerLeft;
        }
        if(scorePlayerRight > sagskor)
        {
            sagsıra.gameObject.SetActive(false);
            solsıra.gameObject.SetActive(true);
            sagskor = scorePlayerRight;
        }


		// check for winning condition
		if (scorePlayerLeft >= winningScore || scorePlayerRight >= winningScore)
		{
			// disable ball
			GameObject ball = GameObject.Find("para");
			if (ball != null)
			{
				ball.SetActive(false);
			}
            ekran();
		}

	}
    public void ekran()
    {
        cnv.gameObject.SetActive(true);
        solTxt.text = scorePlayerLeft.ToString();
        sagTxt.text = scorePlayerRight.ToString();
        if(scorePlayerLeft >= winningScore)
        {
            win.text = "<<YOU WIN";
        }
        else
        {
            win.text = "YOU WIN>>";
        }
    }
}
