using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletBehavior : MonoBehaviour
{
    GameObject ittetsu;
    Vector3 ittetsu_position;
    Vector3 enemy_to_ittetsu;
    float bullet_speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        ittetsu = GameObject.Find("ittetsu");
        //ittetsu�̍��W
        ittetsu_position = GameObject.Find("ittetsu").transform.position;
        //enemy -> ittetsu�x�N�g��
        enemy_to_ittetsu = ittetsu_position - this.transform.position;
        enemy_to_ittetsu = enemy_to_ittetsu.normalized;
        //enemy�̌�����ittetsu�Ɍ�������
        this.transform.rotation = Quaternion.FromToRotation(Vector3.up, enemy_to_ittetsu);

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + enemy_to_ittetsu * bullet_speed;
    }
}

