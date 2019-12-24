using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDirection;
    private CharacterController controller;
    private Animator anim;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        moveSpeed = 10f;
        anim = GetComponent<Animator>();
    }

    void Update()
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
            controller.Move(new Vector3(0f, 0f, 0f));
        }
        moveDirection = new Vector3Int((int)(x * moveSpeed),0,(int)(z*moveSpeed));
        moveDirection.y += Physics.gravity.y;//Yer cekimi
        controller.Move(moveDirection*Time.deltaTime);
        anim.SetFloat("Speed",Math.Abs(x)+Math.Abs(z));
        
    }
}
