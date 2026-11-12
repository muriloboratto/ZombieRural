using UnityEngine;
using UnityEngine.UI;             // For UI elements
using UnityEngine.SceneManagement; // For reloading the scene
using System.Collections;
using TMPro;
using System.Collections.Generic;


    public class PlayerController : MonoBehaviour
    {
       
        public float speed = 1.0f; // the movement speed of the player
        private Rigidbody2D rb;
        private Vector2 movementDirection;



        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            
        }

        void Update()
{
    HandleMovement();
}

void FixedUpdate()
{
    if (movementDirection != Vector2.zero)
    {
        rb.MovePosition(rb.position + movementDirection * speed * Time.fixedDeltaTime);
    }
}

void HandleMovement()
{
    float horizontal = 0f;
    float vertical = 0f;

    if (Input.GetKey(KeyCode.UpArrow))
    {
        vertical = 1f;
    }

    if (Input.GetKey(KeyCode.DownArrow))
    {
        vertical = -1f;
    }

    if (Input.GetKey(KeyCode.RightArrow))
    {
        horizontal = 1f;
    }

    if (Input.GetKey(KeyCode.LeftArrow))
    {
        horizontal = -1f;
    }

    movementDirection = new Vector2(horizontal, vertical).normalized;
}

    }