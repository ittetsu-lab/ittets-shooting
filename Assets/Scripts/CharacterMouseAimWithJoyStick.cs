using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 視点移動が可能
 * 
 * (使用方法)
 * 1. 本プログラム(CharacterMouseAimWithJoyStick)を
 * 2. FixedJoyStick inputRoteにFixedJoyStickオブジェクトをアタッチする
 * (コードださいです)
*/
public class CharacterMouseAimWithJoyStick : MonoBehaviour
{
    public FixedJoystick inputRotate;
    float ver_CameraRate = 0.0F; // 垂直方向の視点移動制御
    float hor_CameraRate = 0.0F; // 水平方向の視点移動制御

    public bool ver_check = true; //垂直方向の視点移動を有効化
    
    public float ver_speed = 0.5F; // 垂直方向の視点移動スピード
    public float hor_speed = 1.0F; // 水平方向の視点移動スピード

    public float ver_constraint_up = -0.15F; // 上向き方向の視点移動制限
    public float ver_constraint_down = 0.2F; // 下向き方向の視点移動制限
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ver_CameraRate = inputRotate.Vertical;
        hor_CameraRate = inputRotate.Horizontal;
        //Debug.Log("ver_CameraRate1 : " + ver_CameraRate);
        //Debug.Log("hor_CameraRate1 : " + hor_CameraRate);

        //hor_Rotation.
        transform.Rotate(new Vector3(0, hor_speed * hor_CameraRate, 0));

        //ver_Rotation.
        if (ver_check)
        {
            float rotate_x = transform.rotation.x;
            //Debug.Log("rotate_x : " + rotate_x);

            if (rotate_x < ver_constraint_up)
            {
                transform.Rotate(new Vector3(0.01F, 0, 0));
            }
            else if (rotate_x > ver_constraint_down)
            {
                transform.Rotate(new Vector3(-0.01F, 0, 0));
            }
            else
            {
                transform.Rotate(new Vector3(-ver_speed * ver_CameraRate, 0.0F, 0.0F));
            }
        }
    }
}