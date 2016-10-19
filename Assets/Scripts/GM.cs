using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    private static GM Self;
    private static int points;

    private Rigidbody rb;
    private int count;

    public float speed;
    [SerializeField]
    private Text countText;
    public Text winText;

    // Use this for initialization
    void Awake ()
    {
        if (Self == null)
        {
            Self = this;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void addScore(int value)
    {
        points += value;
        Debug.Log("Points = " + points);
    }

    public static int getScore()
    {
        return points;
    }

    void Start()
    {
        count = 0;
        winText.text = "";
    }



    void Win()
    {
        winText.text = "You Win!";
    }
}
