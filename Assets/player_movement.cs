using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_movement : MonoBehaviour
{
    [SerializeField] float boostModifier;
    public Rigidbody2D rb;
    public Vector2 input_dir;


    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        // jetpack
        // rb.AddForce(input_dir * boostModifier);
    }
    private void OnMove(InputValue value)
    {
        Vector2 movement_dir = value.Get<Vector2>();
        
        // restrain vertical movement
        movement_dir = new Vector2(movement_dir.x, 0).normalized;
        Debug.Log(movement_dir);
        rb.AddForce(movement_dir * boostModifier, ForceMode2D.Impulse);
        // jetpack
        // input_dir = movement_dir;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("boing");
    }



}




