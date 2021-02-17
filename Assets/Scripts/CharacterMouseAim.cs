using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouseAim : MonoBehaviour
{
	public Transform ver_Rotation; // 親オブジェクト(player本体)のTransformを指定
 	public Transform hor_Rotation; // CameraオブジェクトのTransformを指定
    public float ver_CameraRate = 5.0F; // 垂直方向の視点移動度合
    public float hor_CameraRate = 1.0F; // 水平方向の視点移動度合

    // Start is called before the first frame update
    void Start()
    {
        ver_Rotation = transform.parent;
		hor_Rotation = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    	float X_Rotation = Input.GetAxis("Mouse X");
		float Y_Rotation = Input.GetAxis("Mouse Y");
		ver_Rotation.transform.Rotate(0, X_Rotation*ver_CameraRate, 0);
		hor_Rotation.transform.Rotate(-Y_Rotation*hor_CameraRate, 0, 0);
    }
}