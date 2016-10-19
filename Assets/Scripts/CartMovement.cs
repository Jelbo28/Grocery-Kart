using UnityEngine;
using System.Collections;

public class CartMovement : MonoBehaviour
{
    [SerializeField]
    KeyCode[] Controls;

    Vector3 cartPos;

    private static int tilePos;

    [SerializeField]
    float gapDistance;

    void Start()
    {
        tilePos = 0;
        cartPos = gameObject.transform.position;
    }

    void Update ()
    {
        if (Input.GetKeyDown(Controls[0]) && tilePos >= 0)
        {
            Debug.Log("Left");
            cartPos.x -= gapDistance;
            tilePos--;
        }

        if (Input.GetKeyDown(Controls[1]) && tilePos <= 0)
        {
            Debug.Log("Right");
            cartPos.x += gapDistance;
            tilePos++;
        }
        gameObject.transform.position = cartPos;
    }
}
