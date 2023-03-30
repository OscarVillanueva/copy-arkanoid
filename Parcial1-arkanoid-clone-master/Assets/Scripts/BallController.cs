using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{

    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GameManager.sharedInstance.StartLevel(4, "Level1");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    /*
     * Move the player using the rigidbody
     */
    private void MovePlayer()
    {
        Vector2 currentMovement = new(0, 0);
        rigidBody.velocity = currentMovement.normalized * 10;
    }
}
