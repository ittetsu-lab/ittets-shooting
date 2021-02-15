using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Playerにアタッチしたら、fpsっぽくなる(by miilab)
 */

public class GyroControllerInAndroid : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, -180) * Quaternion.Euler(-90, 0, 0) * Input.gyro.attitude * Quaternion.Euler(0, 0, 180);
    }
}