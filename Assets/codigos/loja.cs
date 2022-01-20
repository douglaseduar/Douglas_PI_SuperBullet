using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loja : MonoBehaviour
{
    public Button arma1;
    int dinheiro;
    int arma;
    int puloDuplo;
    public Button arma2;
    public Button arma3;
    public Button duplo;
    public Text textarma1;
    public Text textarma2;
    public Text textarma3;
    public Text pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        dinheiro = PlayerPrefs.GetInt("dinheiro");
        puloDuplo = PlayerPrefs.GetInt("duplo");
       
    }
    // Update is called once per frame
    void Update()
    {
            pontuacao.text = "" + dinheiro;
            dinheiro = PlayerPrefs.GetInt("dinheiro");
            arma = PlayerPrefs.GetInt("arma");
            puloDuplo = PlayerPrefs.GetInt("duplo");

            if (dinheiro < 100)
            {
                arma1.interactable = false;//SetActive(false);
            }
            if (dinheiro < 200)
            {
                arma2.interactable = false;//SetActive(false);
                duplo.interactable = false;//SetActive(false);
            }
            if (dinheiro < 300)
            {
                arma3.interactable = false;//SetActive(false);
            }
            if(arma == 2)
            {
                arma1.interactable = false;//SetActive(false);
                textarma1.text = "Já foi comprado";
                arma2.interactable = false;//SetActive(false);
                textarma2.text = "Já foi comprado";
             }
            if(arma == 3)
            {
                 arma1.interactable = false;//SetActive(false);
                 arma2.interactable = false;//SetActive(false);
                 arma3.interactable = false;
                 textarma1.text = "Já foi comprado";
                 textarma2.text = "Já foi comprado";
                 textarma3.text = "Já foi comprado";
        }
            if(puloDuplo == 1)
            {
                duplo.interactable = false;
            }
    }
    public void compraArma(int arma)
    {
        PlayerPrefs.SetInt("arma", arma);
    }
    public void PuloDuplo(int num)
    {
        PlayerPrefs.SetInt("duplo", num);
    }
    public void comprou (int valor)
    {
        PlayerPrefs.SetInt("dinheiro", dinheiro-valor);
    }
    public void mudarDano (int dano)
    {
        PlayerPrefs.SetInt("dano", dano);
    }
}
