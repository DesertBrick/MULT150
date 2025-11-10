using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public static float Speed { get; private set; } = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hInput, 0f, vInput) * Speed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
