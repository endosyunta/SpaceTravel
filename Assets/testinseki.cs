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
        // Cube�v���n�u��GameObject�^�Ŏ擾
        nejiPrefab = (GameObject)Resources.Load("neji") as GameObject;

    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(firePoint);
    }
}
