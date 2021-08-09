using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
//using UnityChan;


public class DeadWallCtrl : MonoBehaviour
{
    [Header("オブジェクトの速度")] public float speed = 0.05f;
    [Header("横移動の制限")] public float max_x = 10.0f;
    [Header("プレイヤー")] public GameObject player;
    [Header("テキスト")] public GameObject text;

    //ゲームオーバー判定
    private bool isGameOver = false;
    //RestartManager型
    private RestartManager restart;


    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player, text);
    }


    void Update()
    {
        //フレーム毎にspeed分X軸に移動
        this.gameObject.transform.Translate(speed, 0, 0);

        //X軸が一定まで達すると、向きを反対にする
        if (this.gameObject.transform.position.x > max_x || this.gameObject.transform.position.x < (-max_x))
        {
            speed *= -1;
        }

        //ゲームオーバー状態でクリックしたとき
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        //プレイヤーとの接触判定
        if (other.gameObject.name == player.name)
        {
            //RestartManagerで処理
            restart.PrintGameOver();
        }
    }
        
}
