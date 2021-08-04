using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoaiManager : MonoBehaviour
{

    [Header("プレイヤー")]public GameObject player;
    [Header("テキスト")]public GameObject text;

    void Start()
    {
        
    }


    void Update()
    {
       
    }


   

    //当たり判定
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            text.GetComponent<Text>().text = "Goal!!";
            text.SetActive(true);    
            Debug.Log("何かがせっしょくした");
        }
    }
    
}
