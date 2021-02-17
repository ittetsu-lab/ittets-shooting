using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 視点移動が可能
 * 
 * (使用方法)
 * 1. 本プログラム(CharacterMouseAimWithJoyStick)を
 * 2. FixedJoyStick inputRoteにFixedJoyStickオブジェクトをアタッチする
*/
public class CharacterMouseAimWithJoyStick : MonoBehaviour
{
    public FixedJoystick inputRotate;
    public float ver_CameraRate = 0.0F; // 垂直方向の視点移動制御
    public float hor_CameraRate = 0.0F; // 水平方向の視点移動制御

    public float ver_speed = 1.0F; // 垂直方向の視点移動スピード
    public float hor_speed = 1.0F; // 水平方向の視点移動スピード
    public float ver_CameraRate_limit = 1.0F; // 垂直方向の視点移動制限
    //public float hor_CameraRate_limit = 1.0F; // 水平方向の視点移動制限

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ver_CameraRate = inputRotate.Vertical;
        hor_CameraRate = inputRotate.Horizontal;
        //Debug.Log(inputRotate.Direction);

        //Debug.Log("ver_CameraRate1 : " + ver_CameraRate);
        //Debug.Log("hor_CameraRate1 : " + hor_CameraRate);

        //if (inputRotate.Vertical <= -ver_CameraRate_limit || inputRotate.Vertical >= ver_CameraRate_limit)
        //{
            //ver_CameraRate = 0;
        //}
        //if (inputRotate.Horizontal <= -hor_CameraRate_limit || inputRotate.Horizontal >= hor_CameraRate_limit)
        //{
            //hor_CameraRate = 0;
        //}

        //Debug.Log("ver_CameraRate2 : " + ver_CameraRate);
        //Debug.Log("hor_CameraRate2 : " + hor_CameraRate);

        transform.Rotate(new Vector3(0, hor_speed * hor_CameraRate, 0));
        //transform.Rotate(new Vector3(-ver_speed * ver_CameraRate, 0, 0));
    }
}