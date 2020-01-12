using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDirection;

    private Rigidbody rgPlayer;
    //private CharacterController controller;
    private Animator anim;

    private void Awake()
    {
        //controller = GetComponent<CharacterController>();
        rgPlayer = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        moveSpeed = 10f;
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (x>0 || x<0)
        {
            z = 0;
        }
        else if (z>0 || z<0)
        {
            x = 0;
        }
        else
        {
        }
        
        moveDirection = new Vector3Int((int)(x * moveSpeed),0,(int)(z*moveSpeed));
        rgPlayer.velocity = moveDirection;
        if (Input.GetKeyUp("up") || Input.GetKeyUp("down") || Input.GetKeyUp("left") || Input.GetKeyUp("right"))
        {
            //controller.Move(new Vector3(0f, 0f, 0f));
            rgPlayer.velocity = Vector3.zero;
        }
        transform.LookAt(transform.position+ new Vector3(moveDirection.x,0,moveDirection.z));
        //moveDirection.y += Physics.gravity.y;//Yer cekimi
        //controller.Move(moveDirection*Time.deltaTime);
        anim.SetFloat("Speed",Math.Abs(x)+Math.Abs(z));
        
    }
}
