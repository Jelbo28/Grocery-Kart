using UnityEngine;
using System.Collections;

public class ItemPickup : MonoBehaviour {
    public int pointValue;

    void OnTriggerEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("addScore");
            GM.addScore(pointValue);
            gameObject.SetActive(false);
        }
    }
}
