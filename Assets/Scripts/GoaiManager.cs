using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoaiManager : MonoBehaviour
{

    [Header("プレイヤー")]public GameObject player;
    [Header("テキスト")]public GameObject text;


    //プライベート変数
    private bool isGoal = false;

    //RestartManager型
    private RestartManager restart;

    void Start()
    {
        
    }


    void Update()
    {
       if(isGoal && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }


   

    //当たり判定
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            //テキストの内容変更
            text.GetComponent<Text>().text = "Goal!!\n画面クリックで再スタート";
            //テキストをオンにし非表示→表示
            text.SetActive(true);
            isGoal = true;
        }
    }

    private void Restart()
    {
        //現在のScene名を取得
        Scene loadScene = SceneManager.GetActiveScene();
        //Sceeneの読み直し
        SceneManager.LoadScene(loadScene.name); 
    }
    
}
