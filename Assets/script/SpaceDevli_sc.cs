using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDevli_sc : MonoBehaviour
{
    float timer = 0;
    float jikan = 0;
    float fall = 0;
    float rec = 0;

    [SerializeField] float fallspd;

    int key;
    // Start is called before the first frame update
    void Start()
    {
        GameObject d = GameObject.FindWithTag("scoreupdate");
        Debug.Log(d.name);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        jikan += Time.deltaTime;
        rec += Time.deltaTime;
        fall += Time.deltaTime;

        if (timer >= 2.0f)
        {
            neji();
            timer = 0;
        }

        if(jikan >= 2.5f)
        {
            natto();
            jikan = 0;
        }

        if(rec >= 6.5f)
        {
            doram();
            rec = 0;
        }

        if(fall >= 9.0f)
        {
            bombe();
            fall = 0;
        }
    }

    void neji()
    {
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("neji");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(Random.Range(-7.0f,6.5f), 6.0f, 0.0f), Quaternion.identity);
    }

    void natto()
    {
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("natto");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(Random.Range(-7.0f, 6.5f), 6.0f, 0.0f), Quaternion.identity);
    }

    void doram()
    {
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("doram");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(Random.Range(-7.0f, 6.5f), 6.0f, 0.0f), Quaternion.identity);
    }

    void bombe()
    {
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("bombe");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(Random.Range(-7.0f, 6.5f), 6.0f, 0.0f), Quaternion.identity);
    }
}
