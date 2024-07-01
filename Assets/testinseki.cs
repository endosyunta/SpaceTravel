using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testinseki : MonoBehaviour
{
    public Transform firePoint;
    public GameObject nejiPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // CubeプレハブをGameObject型で取得
        nejiPrefab = (GameObject)Resources.Load("neji") as GameObject;

    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(firePoint);
    }
}
