using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 5.0f;

    public Animator animator;

    void Start()
    {


    }

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
