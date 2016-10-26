using UnityEngine;
using System.Collections;

public class FloorMover2 : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(WaitAndMove());
    }
    IEnumerator WaitAndMove()
    { 
        transform.position -= Vector3.forward * 3/8;
        yield return new WaitForSeconds(1);
        StartCoroutine(WaitAndMove());
    }

}   
    



    
          

