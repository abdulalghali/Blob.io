using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobSpeed : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D rb;

    void Update()
    {
        rb.velocity = transform.position * Speed;
    }
}