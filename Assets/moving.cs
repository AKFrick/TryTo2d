﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float speed = 3.0f;
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
            return;

        // Assign velocity based upon direction of conveyor belt
        // Ensure that conveyor mesh is facing towards its local Z-axis
        float conveyorVelocity = speed * Time.deltaTime;
        Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();
        rigidbody.velocity = conveyorVelocity * transform.forward;
    }
}
