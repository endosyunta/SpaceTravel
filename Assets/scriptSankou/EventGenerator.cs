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
    }
    void GenerateRandomNumber()
    {
        // 0����100�͈̗̔͂�������
        float randomValue = Random.Range(0f, 100f);
        //Debug.Log("Random Number: " + randomValue);

        // 80�ȏ�̏ꍇ�A�N��
        if (randomValue >= 80f)
        {
            Debug.Log("����");
        }
    }
}
