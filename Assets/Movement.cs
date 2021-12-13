using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runspeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            jump = true;
        }

    }

    private void FixedUpdate()
    {
       //move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
