using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpaveDevli : MonoBehaviour,IPointerClickHandler
{

    public GameObject score;
    public float fallspd;
    float timer = 0;
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(this.gameObject);
        score.GetComponent<ScoreUpdate>().kaisyu();
    }
    // Start is called before the first frame update
    
    public void Start()
    {
        score = GameObject.FindWithTag("scoreupdate");
    }


    // Update is called once per frame
    public void Update()
    {
        Transform myTransform = this.transform;
        Vector2 pos = myTransform.position;

        if(pos.y < -15)
        {
            Destroy(this.gameObject);
        }
    }

    public void FixedUpdate()
    {
        // transform‚ðŽæ“¾
        Transform myTransform = this.transform;
        // Œ»Ý‚ÌÀ•W‚©‚ç‚Ìxyz ‚ð1‚¸‚Â‰ÁŽZ‚µ‚ÄˆÚ“®
        myTransform.Translate(0, fallspd, 0, Space.World);
    }
}
