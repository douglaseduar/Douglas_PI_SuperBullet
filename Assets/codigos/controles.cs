using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controles : MonoBehaviour
{
    string hora;
    string minuto;
    string segundo;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("arma", 0);
        PlayerPrefs.SetInt("duplo", 0);
        PlayerPrefs.SetInt("dinheiro", 0);
        PlayerPrefs.SetInt("dano", 5);
        PlayerPrefs.SetInt("trofeu", 0);
        PlayerPrefs.SetInt("morte", 0);
        PlayerPrefs.SetInt("total", 0);
        hora = System.DateTime.Now.ToString("HH");
        minuto = System.DateTime.Now.ToString("mm");
        segundo = System.DateTime.Now.ToString("ss");
        PlayerPrefs.SetInt("hora", System.Convert.ToInt32(hora));
        PlayerPrefs.SetInt("minuto", System.Convert.ToInt32(minuto));
        PlayerPrefs.SetInt("segundo", System.Convert.ToInt32(segundo));


        StartCoroutine("teste");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator teste()
    {
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene(3);
    }
}
