using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    float span = 1.0f;
    float delta = 0;
    float delete_time = 5.0f;
    GameObject enemy;
    Vector3 enemy_position;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("enemy");
        enemy_position = enemy.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(bulletPrefab) as GameObject;
            go.transform.position = enemy_position;
            //時間経過でオブジェクト削除
            Destroy(go, delete_time);
        }
    
        

    }
}
