using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCharachterScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMove;
    private float verticalMove;
    private int speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 200;
    }
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontalMove * Time.deltaTime * speed, verticalMove * Time.deltaTime * speed, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("kazand�n");
        }
    }
}
