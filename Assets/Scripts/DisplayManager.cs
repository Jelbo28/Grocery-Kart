using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour {

    [SerializeField]
    private Text countText;
    public Text winText;

    int currentScore;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GM.getScore() > currentScore)
        {
            currentScore = GM.getScore();
            Score();
        }
	
	}

    void Score()
    {
        countText.text = "Score: " + currentScore;
    }

    void Win()
    {
        winText.text = "You Win!";
    }
}
