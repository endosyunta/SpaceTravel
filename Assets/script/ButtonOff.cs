using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOff : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] float limit;
    float time;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time >= limit)
        {
            button.gameObject.SetActive(true);
            time = 0.0f;
        }
    }

    private void OnEnable()
    {
        count++;
        if(count >= 2)
        {
            button.gameObject.SetActive(false);
        }
    }
}
