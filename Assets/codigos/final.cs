using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class final : MonoBehaviour
{
    Text mortes;
    Text dinheiro;
    Text trofeu;
    // Start is called before the first frame update
    void Start()
    {
        mortes = this.transform.GetChild(3).gameObject.GetComponent<Text>();
        dinheiro = this.transform.GetChild(6).gameObject.GetComponent<Text>();
        trofeu = this.transform.GetChild(4).gameObject.GetComponent<Text>();
        mortes.text = "Mortes até aqui: " + PlayerPrefs.GetInt("morte");
        trofeu.text = "Troféus: " + PlayerPrefs.GetInt("trofeu") + " / 3";
        dinheiro.text = "Moedas até aqui: " + PlayerPrefs.GetInt("total");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
