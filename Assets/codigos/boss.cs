using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    public GameObject ponto11, ponto22;
    private Vector2 nextPos;
    public bool ladoDireito = true;
    public Transform CriarProjetil1;
    public Transform CriarProjetil2;
    public Transform CriarProjetil3;
    public Transform CriarProjetil4;
    public Transform CriarProjetil5;
    public Transform CriarProjetil6;
    public GameObject ProjetilJogador1;
    public GameObject ProjetilJogador2;
    int atirou = 0;
    public int vida = 300;
    public Slider barravidaBOSS1;
    int dano;
    int vidaatual;
    public int danochefao = 30;
    public GameObject coin;
    public Transform Criarcoin;
    // Start is called before the first frame update

    void Start()
    {
        dano = PlayerPrefs.GetInt("dano");
        nextPos = ponto22.transform.position;
        atirar();
    }

    // Update is called once per frame
    void Update()
    {
        vidaatual = PlayerPrefs.GetInt("vida");
        movingPlataforma();

        if (vida <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(coin, Criarcoin.position, Criarcoin.rotation);
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
        transform.position = Vector2.MoveTowards(transform.position, nextPos, 2f * Time.deltaTime);
    }
    void Vire()
    {
        ladoDireito = !ladoDireito;

        Vector2 novoScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        Vector2 novoScale1 = new Vector2(barravidaBOSS1.transform.localScale.x * -1, barravidaBOSS1.transform.localScale.y);

        transform.localScale = novoScale;
        barravidaBOSS1.transform.localScale = novoScale1;
    }
    void atirar()
    {
        if (ladoDireito && atirou == 0)
        {
            atirou++;
            Instantiate(ProjetilJogador1, CriarProjetil1.position, CriarProjetil1.rotation);
            Instantiate(ProjetilJogador1, CriarProjetil2.position, CriarProjetil2.rotation);
            Instantiate(ProjetilJogador1, CriarProjetil3.position, CriarProjetil3.rotation);
            Instantiate(ProjetilJogador2, CriarProjetil4.position, CriarProjetil4.rotation);
            Instantiate(ProjetilJogador2, CriarProjetil5.position, CriarProjetil5.rotation);
            Instantiate(ProjetilJogador2, CriarProjetil6.position, CriarProjetil6.rotation);
        }
        else if (!ladoDireito && atirou == 00)
        {
            atirou++;
            Instantiate(ProjetilJogador2, CriarProjetil1.position, CriarProjetil1.rotation);
            Instantiate(ProjetilJogador2, CriarProjetil2.position, CriarProjetil2.rotation);
            Instantiate(ProjetilJogador2, CriarProjetil3.position, CriarProjetil3.rotation);
            Instantiate(ProjetilJogador1, CriarProjetil4.position, CriarProjetil4.rotation);
            Instantiate(ProjetilJogador1, CriarProjetil5.position, CriarProjetil5.rotation);
            Instantiate(ProjetilJogador1, CriarProjetil6.position, CriarProjetil6.rotation);
        }
        StartCoroutine("teste");
    }
    IEnumerator teste()
    {
        yield return new WaitForSeconds(3.0f);
        atirou = 0;
        atirar();
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
}
