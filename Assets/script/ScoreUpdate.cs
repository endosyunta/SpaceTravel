using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    [Header("���Ԍo�߂ŃX�R�A��ǉ����A�l���X�V����V�X�e���̕ϐ�")]
    //�ҏW�\
    [SerializeField] int addScore;
    [SerializeField] float interval;
    //�ҏW�s��
    private int score;
    private float timer = 0f;
    private int lv;
    private int lvup = 1000;
    //�X�V����e�L�X�g
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
        //�X�R�A�̏�������ui�\��
        score = 0;
        lv = 1;
        text_Sozai.text = "�f�ށF" + score.ToString();
        text_lv.text = "�X���x���F" + lv.ToString();
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

        //���Ԃ̍X�V
        timer += Time.deltaTime;

        //��莞�Ԍo�߂ŃX�R�A�X�V�����̎��s
        if (timer >= interval)
        {
            timer = 0f;
            score += addScore;
            text_Sozai.text = "�f�ށF" + score.ToString();
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
                text_lv.text = "�X���x���F" + lv.ToString();
                text_Sozai.text = "�f�ށF" + score.ToString();
            }
    }

    public void kaisyu()
    {
        score += Random.Range(30,80);
        text_Sozai.text = "�f�ށF" + score.ToString();
    }
    //*/
}