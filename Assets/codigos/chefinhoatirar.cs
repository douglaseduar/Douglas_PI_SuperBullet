using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chefinhoatirar : MonoBehaviour
{
    public int vida = 50;
    public GameObject coin;
    public Transform Criarcoin;
    public GameObject ponto11, ponto22;
    private Vector2 nextPos;
    public int danochefao = 5;
    int vidaatual;
    int dano;
    public bool ladoDireito = true;
    public Transform CriarProjetil;
    public GameObject ProjetilJogador;
    public GameObject ProjetilJogador1;
    int atirou = 0;
    // Start is called before the first frame update
    void Start()
    {
        dano = PlayerPrefs.GetInt("dano");
        atirar();
        nextPos = ponto22.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        vidaatual = PlayerPrefs.GetInt("vida");
        if (vida <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(coin, Criarcoin.position, Criarcoin.rotation);
        }
        movingPlataforma();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("tiro"))
        {
            vida -= dano;
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("vida", vidaatual - danochefao);

        }
    }
    private void movingPlataforma()
    {

        if (transform.position == ponto11.transform.position)
        {
            nextPos = ponto22.transform.position;
            Vire();
        }
        if (transform.position == ponto22.transform.position)
        {
            nextPos = ponto11.transform.position;
            Vire();

        }
        transform.position = Vector2.MoveTowards(transform.position, nextPos, 3f * Time.deltaTime);
    }
    void Vire()
    {
        ladoDireito = !ladoDireito;

        Vector2 novoScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);

        transform.localScale = novoScale;
    }

    void atirar()
    {
        if (ladoDireito && atirou == 0)
        {
            atirou++;
            Instantiate(ProjetilJogador, CriarProjetil.position, CriarProjetil.rotation);
        }
        else if (!ladoDireito && atirou == 00)
        {
            atirou++;
            Instantiate(ProjetilJogador1, CriarProjetil.position, CriarProjetil.rotation);
        }
        StartCoroutine("teste");
    }
    IEnumerator teste()
    {
        yield return new WaitForSeconds(3.0f);
        atirou = 0;
        atirar();
    }
}
