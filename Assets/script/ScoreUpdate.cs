using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    [Header("時間経過でスコアを追加し、値を更新するシステムの変数")]
    //編集可能
    [SerializeField] int addScore;
    [SerializeField] float interval;
    //編集不可
    private int score;
    private float timer = 0f;
    private int lv;
    private int lvup = 1000;
    //更新するテキスト
    [SerializeField] TextMeshProUGUI text_Sozai = null;
    [SerializeField] TextMeshProUGUI text_lv = null;
    [SerializeField] Button lvupBtn;
    [SerializeField] GameObject hospital;
    [SerializeField] GameObject tunk;
    [SerializeField] GameObject koujou;
    public GameObject obj;
    //public GameObject[] Prefabs;
    void Start()
    {
        //スコアの初期化とui表示
        score = 0;
        lv = 1;
        text_Sozai.text = "素材：" + score.ToString();
        text_lv.text = "街レベル：" + lv.ToString();
        lvupBtn.onClick.AddListener(Lvup);
    }

    void OnEnable()
    {
        timer = 0f;
    }


    // Update is called once per frame
    void Update()
    {
        /*
        if(obj.activeInHierarchy)
        {

        //時間の更新
        timer += Time.deltaTime;

        //一定時間経過でスコア更新処理の実行
        if (timer >= interval)
        {
            timer = 0f;
            score += addScore;
            text_Sozai.text = "素材：" + score.ToString();
        }
        }
        */

            if (lv == 2)
        {
            hospital.gameObject.SetActive(true);
        }
        if (lv == 3)
        {
            tunk.gameObject.SetActive(true);
        }
        if(lv == 4)
        {
            koujou.gameObject.SetActive(true);
        }
    }
    private void Lvup()
    {
        
        if(score >= 1000)
        {
        lv += 1;
        score -= lvup;
                text_lv.text = "街レベル：" + lv.ToString();
                text_Sozai.text = "素材：" + score.ToString();
            }
    }

    public void kaisyu()
    {
        score += Random.Range(30,80);
        text_Sozai.text = "素材：" + score.ToString();
    }
    //*/
}