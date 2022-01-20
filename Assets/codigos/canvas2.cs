using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas2 : MonoBehaviour
{
    Text pontuacao;
    Slider barravida;
    void Awake()
    {
        pontuacao = this.transform.GetChild(2).gameObject.GetComponent<Text>();
        barravida = this.transform.GetChild(4).gameObject.GetComponent<Slider>();
        barravida.maxValue = 100;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pontuacao.text = "" + PlayerPrefs.GetInt("dinheiro");
        barravida.value = PlayerPrefs.GetInt("vida");
    }
}
