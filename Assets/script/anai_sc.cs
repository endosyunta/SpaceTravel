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
        text_annnai.text = "このゲームは宇宙に浮かぶスペースデブリを素材として回収し、集めた素材で街を発展させていくゲームです。" +
            "宇宙へ行くボタンでロケットを使って宇宙に行くことができます。"+
            "宇宙からはいつでも戻れますが一度戻るともう一度行くまで時間がかかります。";
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
