using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D body;

    // public sealed float scaleX = transform.localScale.x;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(speed * Move, body.velocity.y);

        if (Move > 0.1f)
        {
            transform.localScale = new Vector3(Math.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (Move < -0.1f)
        {
            transform.localScale = new Vector3(-1 * Math.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            body.AddForce(new Vector2(body.velocity.x, jump));
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
