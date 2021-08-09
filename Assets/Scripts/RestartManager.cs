using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;

public class RestartManager : MonoBehaviour
{
    //プライベート変数
    private GameObject player;
    private GameObject text;

    private bool isGameOver = false;

    //コンストラクタ
    public RestartManager(GameObject player,GameObject text)
    {
        this.player = player;
        this.text = text;
    }

    public void PrintGameOver()
    {
        //ゲームオーバーテキストの表示
        text.GetComponent<Text>().text = "GameOver..\nクリックで再スタート";
        text.SetActive(true);

        //プレイヤーを動かなくする
        player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        //アニメーションをオフ
        player.GetComponent<Animator>().enabled = false;

        //ゲームオーバー
        isGameOver = true;
    }

    public void Restart()
    {
        //現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        //Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
    }

    //ゲームオーバーしているかの判定
    public bool IsGameOver()
    {
        return isGameOver;
    }
}
