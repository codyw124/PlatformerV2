using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller_;

    float horizontalMove_ = 0f;

    float runSpeed_ = 40f;

    bool jump_ = true;

	// get user input
	void Update ()
    {
        horizontalMove_ = Input.GetAxisRaw("Horizontal") * runSpeed_;

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log(jump_);
            jump_ = true;
            Debug.Log(jump_);
        }
	}

    //apply user input
    private void FixedUpdate()
    {

        controller_.Move(horizontalMove_ * Time.fixedDeltaTime, false, jump_);

        //jump_ = false;
    }
}
