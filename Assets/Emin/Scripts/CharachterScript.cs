using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterScript : MonoBehaviour
{
    private float horizontalMove;
    private Rigidbody2D rb;
    private int walkSpeed;
    private int jumpSpeed;
    private SpriteRenderer sr;
    private bool isJump;
    [SerializeField]
    private AudioSource meow;
    [SerializeField]
    private AudioSource catPurring;
    private float catDistance;
    private GameObject target;
    [SerializeField]
    private GameObject interact;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        target = GameObject.FindWithTag("Hedef");
        sr.flipX = false;
        walkSpeed = 100;
        jumpSpeed = 250;
        isJump = false;
    }
    private void FixedUpdate()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(horizontalMove * Time.deltaTime * walkSpeed, rb.velocity.y, 0);
    }
    void Update()
    {
        catDistance = Vector2.Distance(gameObject.transform.position, target.transform.position);
        if (Input.GetKey(KeyCode.D))
        {
            sr.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            rb.AddForce(new Vector2(0, jumpSpeed));
            isJump = true;
        }
        if (Input.GetKey(KeyCode.M) && (!meow.isPlaying && !catPurring.isPlaying))
        {
            meow.Play();
        }
        if (Input.GetKey(KeyCode.R) && (!catPurring.isPlaying && !meow.isPlaying))
        {
            catPurring.Play();
        }
        if (Input.GetKey(KeyCode.S))
        {
            //oturma
        }
        if (catDistance < 5)
        {
            interact.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
                Debug.Log("Etkileþim");
        }
        else if (catDistance >= 5)
            interact.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isJump = false;
    }
}
