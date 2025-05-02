using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationsWithBlend : MonoBehaviour
{
    Animator animator;
    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float deceleration = 0.8f;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        bool isPressingWalking = ((Input.GetAxis("Vertical") > 0.1f) || (Input.GetAxis("Horizontal") > 0.1f) || (Input.GetAxis("Vertical") < -0.1f) || (Input.GetAxis("Horizontal") < -0.1f));
        bool isPressingRunning = Input.GetKey("left shift");

        if(isPressingWalking && (velocity < 1.0f))
        {
            velocity += Time.deltaTime * acceleration;
        }

        if(!isPressingWalking && (velocity > 0.0f))
        {
            velocity -= Time.deltaTime * deceleration;
        }

        if(!isPressingWalking && (velocity < 0.0f))
        {
            velocity = 0.0f;
        }
        animator.SetFloat("Velocity", velocity);
    }
}
