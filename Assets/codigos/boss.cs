using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    // Start is called before the first frame update
    void Start()
    {
        nextPos = ponto22.transform.position;
        atirar();
    }

    // Update is called once per frame
    void Update()
    {
        movingPlataforma();
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

        transform.localScale = novoScale;
    }
    void atirar()
    {
        if (atirou == 0)
        {
            atirou++;
            Instantiate(ProjetilJogador1, CriarProjetil1.position, CriarProjetil1.rotation);
            Instantiate(ProjetilJogador1, CriarProjetil2.position, CriarProjetil2.rotation);
            Instantiate(ProjetilJogador1, CriarProjetil3.position, CriarProjetil3.rotation);
            Instantiate(ProjetilJogador2, CriarProjetil4.position, CriarProjetil4.rotation);
            Instantiate(ProjetilJogador2, CriarProjetil5.position, CriarProjetil5.rotation);
            Instantiate(ProjetilJogador2, CriarProjetil6.position, CriarProjetil6.rotation);
        }
        StartCoroutine("teste");
    }
}
