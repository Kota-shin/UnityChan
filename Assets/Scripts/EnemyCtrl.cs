using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : MonoBehaviour
{
    //追跡するオブジェクトのトランスフォーム
    public Transform targer;
    //エージェントとなるオブジェクトのNavMeshAgent
    public NavMeshAgent agent;

    void Start()
    {
        
    }


    void Update()
    {
        //目的地となる座標を設定する
        agent.destination = targer.position;
    }
}
