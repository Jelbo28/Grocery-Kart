using UnityEngine;
using System.Collections;

public class ItemPickup : MonoBehaviour {

    [SerializeField]
    private int pointValue;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("poop");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("addScore");
            GM.addScore(pointValue);
            gameObject.SetActive(false);
        }
    }
}
