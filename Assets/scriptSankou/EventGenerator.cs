using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventGenerator : MonoBehaviour
{
    private float timer = 0f;
    private float interval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
    }
    void GenerateRandomNumber()
    {
        // 0から100の範囲の乱数生成
        float randomValue = Random.Range(0f, 100f);
        //Debug.Log("Random Number: " + randomValue);

        // 80以上の場合、起動
        if (randomValue >= 80f)
        {
            Debug.Log("成功");
        }
    }
}
