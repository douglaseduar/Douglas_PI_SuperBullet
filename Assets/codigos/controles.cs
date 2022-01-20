using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controles : MonoBehaviour
{
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
