using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeManager : MonoBehaviour
{
    [Header("時間表示テキスト")]public Text timeText;
    [Header("制限時間")] public float limit;
    [Header("ゲームオーバーテキスト")] public GameObject text;
    [Header("プレイヤー")] public GameObject player;

    //プライベート変数
    private bool isGameOver = false;
    //RestartManager型
    private RestartManager restart;

    void Start()
    {
        //インスタンス設定
        restart = new RestartManager(player, text);
        //初期時間の設定
        timeText.text = "残り時間" + limit + "秒";
    }

    void Update()
    {
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }

        //時間制限がきたとき
        if (limit < 0)
        {
            //RestartManagerに処理を任せる
            restart.PrintGameOver();

            //ここでUpdateメソッドを終わらせる
            return;
        }

        //時間をカウントダウン
        limit -= Time.deltaTime;
        timeText.text = "残り時間" + limit.ToString("f1") + "秒";
    }
}
