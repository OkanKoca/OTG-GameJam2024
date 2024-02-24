using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 5.0f;

    public Animator animator;

    private float newX;

    public Transform transform;

    // Update is called once per frame,
    void Update()
    {
     
        if (Input.GetKey("d"))
        {
            animator.SetBool("isWalking", true);
            
     
        }
        
        else 
        {
            animator.SetBool("isWalking", false);
        }
    }
}
