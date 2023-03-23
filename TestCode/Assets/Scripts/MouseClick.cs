using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }
}
