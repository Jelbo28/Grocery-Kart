using UnityEngine;
using System.Collections;

public class CartMovement : MonoBehaviour
{
    [SerializeField]
    KeyCode[] Controls;

    Vector3 cartPos;

    [SerializeField]
    float gapDistance;

    void Start()
    {
        cartPos = gameObject.transform.position;
    }

    void Update ()
    {
        if (Input.GetKeyDown(Controls[0]))
        {
            Debug.Log("Left");
            cartPos.x -= gapDistance;
        }

        if (Input.GetKeyDown(Controls[1]))
        {
            Debug.Log("Right");
            cartPos.x += gapDistance;
        }
        gameObject.transform.position = cartPos;
    }
}
