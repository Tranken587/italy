using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerhorizontalInputment : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    public float jump;
    public bool isJumping;

    private Rigidbody2D body;
    private Animator anim;

    AudioSource shoppingCartMoving;

    // public sealed float scaleX = transform.localScale.x;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.constraints = RigidbodyConstraints2D.FreezeRotation;

        anim = GetComponent<Animator>();

        shoppingCartMoving = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(speed * horizontalInput, body.velocity.y);

        //Flips player sprite to face left or right based on movement direction (Kept scale through brute force abs value)
        if (horizontalInput > 0.1f)
        {
            transform.localScale = new Vector3(Math.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (horizontalInput < -0.1f)
        {
            transform.localScale = new Vector3(-1 * Math.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }

        if(shoppingCartMoving.isPlaying)
        {
            if(horizontalInput == 0f || isJumping)
            {
                shoppingCartMoving.Stop();
            }
        }
        else
        {
            if((horizontalInput > 0.1f || horizontalInput < -0.1f) && !isJumping)
            {
                shoppingCartMoving.Play();
            }
        }

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            body.AddForce(new Vector2(body.velocity.x, jump));
        }

        anim.SetBool("run", horizontalInput != 0);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            anim.SetBool("jump", false);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            anim.SetBool("jump", true);
        }
    }
}
