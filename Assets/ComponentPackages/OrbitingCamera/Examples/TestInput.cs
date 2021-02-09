using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    Orbit orbit;

    void Start()
    {
        orbit = GetComponent<Orbit>();
    }

    void Update()
    {
        orbit.Rotate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
