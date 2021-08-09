using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
    [Header("プレイヤー")]public GameObject player;
    [Header("テキスト")] public GameObject text;

    //プライベート変数
    //RestartMananager型
    private RestartManager restart;

    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player, text);
    }

    
    void Update()
    {
        if(player.transform.position.y < -10)
        {
            restart.PrintGameOver();
        }

        if(restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }
}
