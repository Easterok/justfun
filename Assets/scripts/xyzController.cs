using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xyzController : MonoBehaviour
{
    public Transform XYZ;

    private bool asd = false;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            asd = !asd;

            XYZ.Translate(0, asd ? 1 : -1, 0);
        }
    }
}
