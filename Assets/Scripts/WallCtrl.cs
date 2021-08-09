using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCtrl : MonoBehaviour
{
    [Header("オブジェクトの速度")] public float speed = 0.05f;
    [Header("横移動の制限")] public float max_x = 10.0f;

    void Start()
    {
        
    }


    void Update()
    {
        //フレーム毎にspeed分X軸に移動
        this.gameObject.transform.Translate(speed, 0, 0);

        //X軸が一定まで達すると、向きを反対にする
        if(this.gameObject.transform.position.x > max_x || this.gameObject.transform.position.x < (-max_x))
        {
            speed *= -1;
        }
    }
}
