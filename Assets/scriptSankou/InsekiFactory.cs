using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsekiFactory : MonoBehaviour
{
    [SerializeField] GameObject nejiPrefab;
    [SerializeField] GameObject nattoPrefab;
    [SerializeField] GameObject doram;
    [SerializeField] GameObject bombe;
    [SerializeField] float waitTime;

    [SerializeField] GameObject insPoses;
    void Start()
    {
        StartCoroutine(InsInseki());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator InsInseki()
    {
        while (true)
        {
            int insNum = Random.Range(0,4);
            Vector3 newpos = insPoses.transform.GetChild(insNum).position;
            var insObj = Instantiate(nejiPrefab, newpos, Quaternion.identity);
            insObj.transform.rotation = Quaternion.Euler(0, 0, 180.0f);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
