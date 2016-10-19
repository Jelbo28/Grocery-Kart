using UnityEngine;
using System.Collections;

public class DeathByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        //GM.Win();
    }
}




