using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallStoneAnime : MonoBehaviour
{
    private Animator Stone = null;

    private float timer = 0f;
    private float observer = 0f;
    private float interval = 3f;
    private float secondint =2f;

    bool falling;

    void Start()
    {
        Stone = GetComponent<Animator>();
    }

    void OnEnable()
    {
        timer = 0f;
    }
    
    void Update()
    {
        // 時間の経過を監視
        timer += Time.deltaTime;

        // 3秒ごとに処理を実行
        if (timer >= interval)
        {
            // 乱数生成の処理
            GenerateRandomNumber();

            // タイマーをリセット
            timer = 0f;
        }
        if (falling)
        {
            Stopstone();
        }
    }


    void GenerateRandomNumber()
    {
        // 0から100の範囲の乱数生成
        float randomValue = UnityEngine.Random.Range(0f, 100f);
        //Debug.Log("Random Number: " + randomValue);

        // 80以上の場合、起動
        if (randomValue >= 80f)
        {
            Fallstone();
        }
    }

    void Fallstone()
    {
        //float horizontalKey = Input.GetAxis("Horizontal");

        //if(Input.GetKey(KeyCode.S))
        
            Stone.SetBool("StoneFall", false);

        falling = true;
//            Stopstone();
        
        
        //else
        //if (Input.GetKeyUp(KeyCode.S))

    }
    void Stopstone()
    {
        // 時間の経過を監視
        observer += Time.deltaTime;

        // 3秒ごとに処理を実行
        if (observer >= secondint)
        {
            Stone.SetBool("StoneFall", true);
            falling = false;

            // タイマーをリセット
            observer = 0f;
        }
    }
}
