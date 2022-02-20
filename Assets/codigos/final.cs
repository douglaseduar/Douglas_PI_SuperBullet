using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class final : MonoBehaviour
{
    Text mortes;
    Text dinheiro;
    Text trofeu;
    Text duracao;
    string hora;
    string minuto;
    string segundo;
    int horainicio;
    int minutoinicio;
    int segundoinicio;
    int resultadohora;
    int resultadominuto;
    int resultadosegundo;
    // Start is called before the first frame update
    void Start()
    {
        hora = System.DateTime.Now.ToString("HH");
        minuto = System.DateTime.Now.ToString("mm");
        segundo = System.DateTime.Now.ToString("ss");
        horainicio = PlayerPrefs.GetInt("hora");
        minutoinicio = PlayerPrefs.GetInt("minuto");
        segundoinicio = PlayerPrefs.GetInt("segundo");

        resultadohora = (System.Convert.ToInt32(hora) - horainicio);
        resultadominuto = (System.Convert.ToInt32(minuto) - minutoinicio);
        resultadosegundo = (System.Convert.ToInt32(segundo) - segundoinicio);
        if(resultadosegundo < 0)
        {
            resultadosegundo = resultadosegundo * -1;
        }
        if(resultadominuto < 0)
        {
            resultadominuto = resultadominuto * -1;
        }
        mortes = this.transform.GetChild(3).gameObject.GetComponent<Text>();
        dinheiro = this.transform.GetChild(6).gameObject.GetComponent<Text>();
        trofeu = this.transform.GetChild(4).gameObject.GetComponent<Text>();
        duracao = this.transform.GetChild(7).gameObject.GetComponent<Text>();
        mortes.text = "Mortes até aqui: " + PlayerPrefs.GetInt("morte");
        trofeu.text = "Troféus: " + PlayerPrefs.GetInt("trofeu") + " / 3";
        dinheiro.text = "Moedas até aqui: " + PlayerPrefs.GetInt("total");
        duracao.text = "Duração: " + resultadohora + "h : " + resultadominuto + "m : " + resultadosegundo + "s";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
