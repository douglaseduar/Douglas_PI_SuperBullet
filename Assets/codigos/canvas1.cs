using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas1 : MonoBehaviour
{
    public scriptjogador refjogador;
    Text pontuacao;
    Text saudacao;
    string nomeaux;
    Slider barravida;
    void Awake()
    {
        barravida = this.transform.GetChild(5).gameObject.GetComponent<Slider>();
        refjogador = GameObject.Find("jogador").GetComponent<scriptjogador>();
        pontuacao = this.transform.GetChild(2).gameObject.GetComponent<Text>();
        saudacao = this.transform.GetChild(4).gameObject.GetComponent<Text>();
        nomeaux = PlayerPrefs.GetString("nome");
        barravida.maxValue = 100;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("vida", 100);
        saudacao.text = "Seja bem vindo, " + nomeaux + " ! Sabemos que o caminho é difícil mas dejamos boa sorte...";
        Destroy(saudacao, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        pontuacao.text = "" + PlayerPrefs.GetInt("dinheiro");
        barravida.value = PlayerPrefs.GetInt("vida");

    }
}
