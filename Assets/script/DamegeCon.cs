using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.UIElements;

public class DamegeCon : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public Slider slider;
    public GameObject GameOverText = null;//Text�I�u�W�F�N�g

    //[SerializeField] Slider hpbar;
    int currentHP;
    int maxHP = 100;


    void Start()
    {
        //�X���C�_�[�i�̗̓Q�[�W�j��T��
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        //hp�𖞃^����Ԃɂ���
        slider.value = 1;
        currentHP = maxHP;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void OnEnable()//�A�N�e�B�u��ԂɂȂ����Ƃ�
    {
        slider.value = 1;
        currentHP = maxHP;
    }
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
            //var gameover_text = GameOverText.GetComponent<TextMeshProUGUI>();
            //gameover_text.text = "GAMEOVER";
            SceneManager.LoadScene("GameOverScene");

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            int damage = Random.Range(10, 50);
            currentHP = currentHP - damage;
            slider.value = (float)currentHP / (float)maxHP; ;
        }
    }
}
