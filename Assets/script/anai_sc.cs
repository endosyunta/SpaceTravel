using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class anai_sc : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_annnai = null;
    float timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        text_annnai.text = "���̃Q�[���͉F���ɕ����ԃX�y�[�X�f�u����f�ނƂ��ĉ�����A�W�߂��f�ނŊX�𔭓W�����Ă����Q�[���ł��B" +
            "�F���֍s���{�^���Ń��P�b�g���g���ĉF���ɍs�����Ƃ��ł��܂��B"+
            "�F������͂��ł��߂�܂�����x�߂�Ƃ�����x�s���܂Ŏ��Ԃ�������܂��B";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 40.0f)
        {
            Destroy(text_annnai);
        }
    }
}
