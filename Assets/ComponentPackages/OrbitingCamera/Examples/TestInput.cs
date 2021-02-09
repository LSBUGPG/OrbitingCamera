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
        if (Input.GetButtonDown("Jump"))
        {
            orbit.autoLevel = !orbit.autoLevel;
        }
        orbit.Rotate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
