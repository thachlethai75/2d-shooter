using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 movement;
   
    void Update()
    {
        MovementInput();
    }

    private void FixedUpdate() {
        rb.velocity = movement * moveSpeed;
    }

    void MovementInput(){
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement = new Vector2(x, y).normalized;
    }
}
