using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeed : MonoBehaviour
{

    public float Speed = 5.0f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity -= transform.up * Speed;
    }
    // Update is called once per frame
    void Update()
    {


    }

}
