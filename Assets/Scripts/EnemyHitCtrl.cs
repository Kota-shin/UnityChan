using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitCtrl : MonoBehaviour
{
    [Header("プレイヤー")] public GameObject player;
    [Header("テキスト")] public GameObject text;

    //プライベート変数
    //RestartManager型
    private RestartManager restart;

    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player, text);
    }


    void Update()
    {
        if(restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //接触したのがプレイヤーだった時
        if(other.gameObject.name == player.name)
        {
            restart.PrintGameOver();
        }
    }
}
