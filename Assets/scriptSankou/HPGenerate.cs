using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPGenerate : MonoBehaviour
{

    public Slider slider;
    public GameObject GameOverText = null;//Textオブジェクト
    int maxHP = 100;
    int currentHP;
    //public GameObject Player;
    //private Rigidbody2D rigidBody;
    void Start()
    {
        //スライダー（体力ゲージ）を探す
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        //数値を満タン状態にする
        slider.value = 1;
        currentHP = maxHP;
        //rigidBody = GetComponent<Rigidbody2D>();
    }

    void OnEnable()//アクティブ状態になったとき
    {
        slider.value = 1;
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            int damage = Random.Range(10, 30);
            currentHP = currentHP - damage;
            slider.value = (float)currentHP / (float)maxHP; ;
            Debug.Log("攻撃発生");
        }

        if (currentHP < 0)
        {
            var gameover_text = GameOverText.GetComponent<TextMeshProUGUI>();
            gameover_text.text = "GAMEOVER";
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("katta");
        }
    }*/
}