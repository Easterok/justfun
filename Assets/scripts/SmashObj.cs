using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glass : MonoBehaviour
{
    public Transform brokenObject;
    public float magnitudeCol;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > magnitudeCol)
        {
            Destroy(gameObject);
            Instantiate(brokenObject, transform.position, transform.rotation);
            brokenObject.localScale = transform.localScale;
        }
    }
}
