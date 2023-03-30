using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BarController3D : MonoBehaviour
{

    private Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManager.sharedInstance.StartLevel(18, "Level1");
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
        Vector2 currentMovement = new(Input.GetAxisRaw("Horizontal"), 0);
        rigidBody.velocity = currentMovement.normalized * 10;
    }
}
