using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class BallController3D : MonoBehaviour
{

    private Rigidbody rigidBody;
    [SerializeField] private float speedIncreaseFactor;
    [SerializeField] private float velX;
    [SerializeField] private float velY;
    

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {

        rigidBody.AddForce(new Vector3(velX*10.0f,velY*10.0f,0));
//        rigidBody.velocity = currentMovement.normalized*10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector2 currentMovement = new(10, 10);
        //rigidBody.velocity = currentMovement.normalized * speedIncreaseFactor + currentMovement.normalized;
    }
    private void OnCollisionEnter(Collision collision)
    {
        float randX= Random.Range(-1.0f, 1.0f);
        float randY= Random.Range(1.0f, 10.0f);
        if (collision.gameObject.CompareTag("Bar")) {
            if(randX<=0) {rigidBody.AddForce(new Vector3(velX*-10.0f,velY*10.0f,0));}
            if(randX>0) {rigidBody.AddForce(new Vector3(velX*10.0f,velY*10.0f,0));}
        }
        if (collision.gameObject.CompareTag("Obstacle")) {
            rigidBody.AddForce(new Vector3(velX*-10.0f,velY*-10.0f,0));
        }
        if (collision.gameObject.CompareTag("TopLimit")) {
            rigidBody.AddForce(new Vector3(velX*-10.0f,velY*-10.0f,0));
        }   
        /*     
        if (collision.gameObject.CompareTag("LeftLimit")) {
            rigidBody.AddForce(new Vector3(velX*10.0f,velY*10.0f,0));
        } 
              
        if (collision.gameObject.CompareTag("RightLimit")) {
            rigidBody.AddForce(new Vector3(velX*-10.0f,velY*10.0f,0));
        }             
        */
    }

}
