using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stone : MonoBehaviour
{
    [SerializeField] float fallSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,fallSpeed * Time.deltaTime,0);
        if(transform.position.y < -10.0f) Destroy(this.gameObject);
    }
}
