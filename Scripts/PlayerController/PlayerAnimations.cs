using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool isPressingWalking = ((Input.GetAxis("Vertical") > 0.1f) || (Input.GetAxis("Horizontal") > 0.1f) || (Input.GetAxis("Vertical") < -0.1f) || (Input.GetAxis("Horizontal") < -0.1f));

        bool isRunning = animator.GetBool("isRunning");
        bool isPressingRunning = Input.GetKey("left shift");

        //walking
        if(!isWalking && isPressingWalking)
        {
            animator.SetBool("isWalking", true);
        }
        
        if(isWalking && !isPressingWalking)
        {
            animator.SetBool("isWalking", false);
        }

        //running
        if((isPressingRunning && isPressingWalking) && !isRunning)
        {
            animator.SetBool("isRunning", true);
        }

        if(isRunning && (!isPressingRunning || !isPressingWalking))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
