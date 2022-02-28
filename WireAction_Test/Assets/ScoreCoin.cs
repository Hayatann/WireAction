using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCoin : MonoBehaviour
{
    [Header("加算するスコア")] public int myScore;
    [Header("プレイヤーの判定")] public PlayerTriggerCheck playerCheck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCheck.isOn){
            if(GameManager.instance != null){
                GameManager.instance.score += myScore;
                Destroy(this.gameObject);
            }
        }
    }
}
