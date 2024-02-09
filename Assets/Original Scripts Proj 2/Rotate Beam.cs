using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBeam : MonoBehaviour
{
    public double rotateSpeed;

    void Start()
    {
        rotateSpeed = 0.2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, (float)rotateSpeed, 0, Space.World);

    }
}
