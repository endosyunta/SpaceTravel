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
        // ���Ԃ̌o�߂��Ď�
        timer += Time.deltaTime;

        // 3�b���Ƃɏ��������s
        if (timer >= interval)
        {
            // ���������̏���
            GenerateRandomNumber();

            // �^�C�}�[�����Z�b�g
            timer = 0f;
        }
        if (falling)
        {
            Stopstone();
        }
    }


    void GenerateRandomNumber()
    {
        // 0����100�͈̗̔͂�������
        float randomValue = UnityEngine.Random.Range(0f, 100f);
        //Debug.Log("Random Number: " + randomValue);

        // 80�ȏ�̏ꍇ�A�N��
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
        // ���Ԃ̌o�߂��Ď�
        observer += Time.deltaTime;

        // 3�b���Ƃɏ��������s
        if (observer >= secondint)
        {
            Stone.SetBool("StoneFall", true);
            falling = false;

            // �^�C�}�[�����Z�b�g
            observer = 0f;
        }
    }
}
