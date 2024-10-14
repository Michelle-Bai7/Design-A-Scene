using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class player_movement : MonoBehaviour
{
    [SerializeField] float boostModifier;
    [SerializeField] public Rigidbody2D rb;
    public Vector2 input_dir;
    public float dash_speed;


    [SerializeField] Animator animator;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
        // jetpack
        // rb.AddForce(input_dir * boostModifier);
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.RightShift)) // Use Space for rolling
        {
            Dash();
        }
    }
    private void OnMove(InputValue value)
    {
        Vector2 movement_dir = value.Get<Vector2>();
        
        // restrain vertical movement
        Vector2 movement_dir_2 = new Vector2(movement_dir.x, 0).normalized;
        Debug.Log(movement_dir_2);
        rb.AddForce(movement_dir_2 * boostModifier, ForceMode2D.Impulse);
        // jetpack
        // input_dir = movement_dir;


        /*movement_dir = new Vector2(movement_dir.x, movement_dir.y).normalized;
        rb.velocity = movement_dir * 3;
        if (Mathf.Approximately(rb.velocity.magnitude, 0))
        {
            animator.SetBool("running", false);

        }
        else {
            animator.SetBool("running", true);
        }*/
        
    }


    void Dash()
    {
        // Add a force in the forward direction of the player
        
        float moveHoriz = Input.GetAxis("Horizontal");
        // Calculate movement direction
        Vector2 moveDir = new Vector2(moveHoriz, 0).normalized;

        Vector2 rollDirection = moveDir * dash_speed;
        rb.AddForce(rollDirection, ForceMode2D.Impulse);
        rb.MovePosition(rb.position + moveDir * dash_speed * Time.fixedDeltaTime);
        Debug.Log("dash");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }



}




