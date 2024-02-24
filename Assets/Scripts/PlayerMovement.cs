using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 5.0f;

    public Animator animator;

    public Animator colorChangeAnim;

    private float newX;

    public SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame,
    void Update()
    {
     
        if (Input.GetKey("d"))
        {
            animator.SetBool("isWalking", true);
            sprite.sortingOrder += 2;
            colorChangeAnim.SetBool("isChanged", true);
            if (CompareTag("confused"))
            {
                Destroy(gameObject);
            }
        }
        
        else 
        {
            animator.SetBool("isWalking", false);
            colorChangeAnim.SetBool("isChanged", false);
        }
    }
}
