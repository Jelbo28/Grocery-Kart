using UnityEngine;
using System.Collections;

public class ObjectRotate : MonoBehaviour {
    [SerializeField]
    private float speed;

	void Update ()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
