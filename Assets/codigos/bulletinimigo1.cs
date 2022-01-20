using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletinimigo1 : MonoBehaviour
{
    public int vidaatual;
    int dano;
    // Start is called before the first frame update
    void Start()
    {
        dano = PlayerPrefs.GetInt("dano");
    }

    // Update is called once per frame
    void Update()
    {
        vidaatual = PlayerPrefs.GetInt("vida");
        Vector3 mov = new Vector3(-8, 0, 0);
        transform.Translate(mov * Time.deltaTime);
        Destroy(this.gameObject, 1f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("vida", vidaatual - dano);
            Destroy(this.gameObject);

        }
        if (collision.gameObject.CompareTag("chao"))
        {
            Destroy(this.gameObject);

        }
    }
}
