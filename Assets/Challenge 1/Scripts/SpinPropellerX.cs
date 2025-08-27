using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 1000.0f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around the Z axis
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}

