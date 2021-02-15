﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    // Use this for initialization
    //void Start () {
    public float speed = 60.0F;
    public float jumpSpeed = 50.0F;
    public float gravity = 70.0F;
    private Vector3 moveDirection = Vector3.zero;
    //}
    //[SerializeField]
    //private ItemManager iM; //List型のItemクラスを呼び出す

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = this.GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        //else{
            //Debug.Log(iM.numOfItem[iM.GetItem("Sword")]);
        //}
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
