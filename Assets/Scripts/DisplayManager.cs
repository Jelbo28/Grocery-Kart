using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour {

    public Text countText;
    public Text winText;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if (GM.getScore >= )
	
	}

    void Win()
    {
        winText.text = "You Win!";
    }
}
