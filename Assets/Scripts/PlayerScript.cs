using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class MovementScript : MonoBehaviour
{

    [SerializeField] private float jumpPower = 16f;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private PlayerInputActions playerControls;

    [SerializeField] private GameObject ScoreUI;

    [SerializeField] private Sprite Falling_Ball;

    [SerializeField] private Sprite Rising_Ball;


    private InputAction jump;
    private bool firstJump = true;

    private void Start()
    {
        rb.gravityScale = 0;

    }

    /* On Awake gets the player input */
    private void Awake() 
    {
        playerControls = new PlayerInputActions();
    }

    /* Enables Player Input */
   private void OnEnable() 
    {
       jump =  playerControls.Player.Jump;
       jump.Enable();
       jump.performed += Jump;
    }

    /* Disables Player Input */
    private void OnDisable() {
        jump.Disable();
    }

    /* Player jump action */
    private void Jump(InputAction.CallbackContext context){

        if(firstJump) 
        {
            rb.gravityScale = 2f;
            FindObjectOfType<GameManager>().CanSpawn();
            FindAnyObjectByType<GameManager>().FirstJumpUI();
        }

        if(rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Wall")
        {
            jump.Disable();
            rb.velocity = new Vector2(-10f, -10f);
            ScoreUI.GetComponent<PointScore>().saveHighScore();
            Invoke("endGamePlayer", 1.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PointTrigger")
        {
            ScoreUI.GetComponent<PointScore>().score();
        }
    }

    private void endGamePlayer()
    {
        FindObjectOfType<GameManager>().changeScene(2);
    }

    private void spriteChanger()
    {
        float velocity = rb.velocity.y;
        Debug.Log(velocity); 

        if (velocity > 0f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Rising_Ball;
        } 
        else 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Falling_Ball;
        }
    }

    private void FixedUpdate()
    {
        spriteChanger();
    }
}
