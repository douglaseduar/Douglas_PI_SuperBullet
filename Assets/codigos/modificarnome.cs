using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class modificarnome : MonoBehaviour
{
    private string nomeJogador;
    public InputField inputField;
    Text saudacao;
    public scriptjogador refjogador;

    // Start is called before the first frame update
    void Start()
    {
        refjogador = GameObject.Find("jogador").GetComponent<scriptjogador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void alterarNome()
    {
        nomeJogador = inputField.text;
        PlayerPrefs.SetString("nome", nomeJogador);
        refjogador.testenome(nomeJogador); 
    }
    void Awake()
    {
        //saudacao = this.transform.GetChild(4).gameObject.GetComponent<Text>();
        
    }
}
