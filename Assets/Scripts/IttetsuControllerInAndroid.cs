using UnityEngine;
using System.Collections;

/*
 * ittetsuchanが十字ボタンで移動できる in Android
 * (もっと無駄省けるが、実行できるからとりあえず良しとする(by miilab))
 */

public class IttetsuControllerInAndroid : MonoBehaviour
{
    CharacterController controller;
    Vector3 moveDirection = Vector3.zero;
    
    public float speed = 50.0F;
    public float gravity = 60.0F;
    public float speedJump = 100.0F;

    bool PressedRight = false;
    bool PressedLeft = false;
    bool PressedUp = false;
    bool PressedDown = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        controller = this.GetComponent<CharacterController>();

        if (PressedRight)
        {
            MoveToRight();
        }
        else if (PressedLeft)
        {
            MoveToLeft();
        }
        else if (PressedUp)
        {
            MoveToForward();
        }
        else if (PressedDown)
        {
            MoveToBack();
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    public void PushDownRight() // →ボタンを押している間
    {
        PressedRight = true;
    }
    public void PushUpRight() // →ボタンを押すのをやめた時
    {
        PressedRight = false;
    }

    public void PushDownLeft() // ←左 ボタンを押している間
    {
        PressedLeft = true;
    }
    public void PushUpLeft() // ←ボタンを押すのをやめた時
    {
        PressedLeft = false;
    }

    public void PushDownForward() // ↑ボタンを押している間
    {
        PressedUp = true;
    }
    public void PushUpForward() // ↑ボタンを押すのをやめた時
    {
        PressedUp = false;
    }

    public void PushDownBack() // ↓ボタンを押している間
    {
        PressedDown = true;
    }
    public void PushUpBack() // ↓ボタンを押すのをやめた時
    {
        PressedDown = false;
    }

    public void MoveToRight()
    {
        transform.position += transform.rotation * new Vector3(speed * Time.deltaTime, 0, 0);
        //Debug.Log("MoveToRight");
    }
    public void MoveToLeft()
    {
        transform.position -= transform.rotation * new Vector3(speed * Time.deltaTime, 0, 0);
        //Debug.Log("MoveToLeft");
    }

    public void MoveToForward()
    {
        transform.position += transform.rotation * new Vector3(0, 0, speed * Time.deltaTime);
        //Debug.Log("MoveToForward");
    }
    public void MoveToBack()
    {
        transform.position -= transform.rotation * new Vector3(0, 0, speed * Time.deltaTime);
        //Debug.Log("MoveToBack");
    }

    public void Jump()
    {
        if (controller.isGrounded)
        {
            moveDirection.y = speedJump;
            //Debug.Log("Jump");
        }
    }
}