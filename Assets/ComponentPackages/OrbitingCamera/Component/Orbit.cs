using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target;
    public float speed = 90.0f;
    public bool invertHorizontal = false;
    public bool invertVertical = false;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        float invert = invertHorizontal? -1.0f : 1.0f;
        transform.Rotate(transform.up, horizontal * speed * invert * Time.deltaTime, Space.World);
        invert = invertVertical? -1.0f : 1.0f;
        transform.Rotate(transform.right, vertical * speed * invert * Time.deltaTime, Space.World);
        transform.position = target.position + transform.forward * -distance;
        transform.LookAt(target);
    }
}
