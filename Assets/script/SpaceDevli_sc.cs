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
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("neji");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(Random.Range(-7.0f,6.5f), 6.0f, 0.0f), Quaternion.identity);
    }

    void natto()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("natto");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(Random.Range(-7.0f, 6.5f), 6.0f, 0.0f), Quaternion.identity);
    }

    void doram()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("doram");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(Random.Range(-7.0f, 6.5f), 6.0f, 0.0f), Quaternion.identity);
    }

    void bombe()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("bombe");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(Random.Range(-7.0f, 6.5f), 6.0f, 0.0f), Quaternion.identity);
    }
}
