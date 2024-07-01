using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPGenerate : MonoBehaviour
{

    public Slider slider;
    public GameObject GameOverText = null;//Text�I�u�W�F�N�g
    int maxHP = 100;
    int currentHP;
    //public GameObject Player;
    //private Rigidbody2D rigidBody;
    void Start()
    {
        //�X���C�_�[�i�̗̓Q�[�W�j��T��
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        //���l�𖞃^����Ԃɂ���
        slider.value = 1;
        currentHP = maxHP;
        //rigidBody = GetComponent<Rigidbody2D>();
    }

    void OnEnable()//�A�N�e�B�u��ԂɂȂ����Ƃ�
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
            Debug.Log("�U������");
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