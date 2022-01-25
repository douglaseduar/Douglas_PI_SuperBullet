using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class scriptjogador : MonoBehaviour
{
	Animator animator;
	float axis;
	Vector2 velocidade;
	public bool ladoDireito = true;
	public Rigidbody2D rb2d;
	public int pontuacao = 0;
	public float MaxVelocidade = 8;
	public string nome;
	bool solo = false;
	int verificacao = 0;
	int duplo;
	public GameObject ProjetilJogador;
	public GameObject ProjetilJogador1;
	public GameObject ProjetilJogador2;
	public GameObject ProjetilJogador3;
	public GameObject ProjetilJogador4;
	public GameObject ProjetilJogador5;
	public GameObject ProjetilJogador6;
	public GameObject ProjetilJogador7;
	public Transform CriarProjetil;
	int qtdmorte;
	int vidaatual;
	public AudioClip somtiro;
	public AudioClip somvida;
	private AudioSource audioS;
	int vidasom;
	// Use this for initialization
	private void Awake()
	{
		CriarProjetil = this.transform.GetChild(1).transform;
	}
	void Start()
	{
		rb2d = this.GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		duplo = PlayerPrefs.GetInt("duplo");
		audioS = gameObject.GetComponent<AudioSource>();
		vidasom = PlayerPrefs.GetInt("vida");
	}

	void FixedUpdate()
	{
		axis = Input.GetAxis("Horizontal");

		if (axis > 0 && !ladoDireito)
			Vire();
		if (axis < 0 && ladoDireito)
			Vire();

		velocidade = new Vector2(axis * MaxVelocidade, GetComponent<Rigidbody2D>().velocity.y);

		GetComponent<Rigidbody2D>().velocity = velocidade;

	}

	// Update is called once per frame
	void Update()
	{
		if(vidasom != PlayerPrefs.GetInt("vida"))
        {
			audioS.clip = somvida;
			audioS.Play();
			vidasom = PlayerPrefs.GetInt("vida");
        }
		qtdmorte = PlayerPrefs.GetInt("morte");
		vidaatual = PlayerPrefs.GetInt("vida");
		if (Input.GetKeyDown(KeyCode.UpArrow) && solo == true)
		{
			rb2d.AddForce(new Vector2(0, 7f), ForceMode2D.Impulse);
			verificacao = 1;
			animator.SetBool("pulo", true);
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow) && verificacao == 1 && duplo == 1)
        {
			rb2d.AddForce(new Vector2(0, 8f), ForceMode2D.Impulse);
			verificacao = 0;
			animator.SetBool("pulo", true);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			audioS.clip = somtiro;
			audioS.Play();
			
			if (PlayerPrefs.GetInt("arma") == 0)
			if (ladoDireito)
			{
				Instantiate(ProjetilJogador, CriarProjetil.position, CriarProjetil.rotation);
			}
            else
            {
				Instantiate(ProjetilJogador1, CriarProjetil.position, CriarProjetil.rotation);
			}
			else if(PlayerPrefs.GetInt("arma") == 1)
            {
				if (ladoDireito)
				{
					Instantiate(ProjetilJogador2, CriarProjetil.position, CriarProjetil.rotation);
				}
				else
				{
					Instantiate(ProjetilJogador3, CriarProjetil.position, CriarProjetil.rotation);
				}
			}
			else if(PlayerPrefs.GetInt("arma") == 2)
            {
				if (ladoDireito)
				{
					Instantiate(ProjetilJogador4, CriarProjetil.position, CriarProjetil.rotation);
				}
				else
				{
					Instantiate(ProjetilJogador5, CriarProjetil.position, CriarProjetil.rotation);
				}
			}
			else if (PlayerPrefs.GetInt("arma") == 3)
            {
				if (ladoDireito)
				{
					Instantiate(ProjetilJogador6, CriarProjetil.position, CriarProjetil.rotation);
				}
				else
				{
					Instantiate(ProjetilJogador7, CriarProjetil.position, CriarProjetil.rotation);
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			animator.SetBool("andar", true);
		}
		if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
		{
			animator.SetBool("andar", false);
		}
		if(vidaatual <= 0)
        {
			SceneManager.LoadScene(4);
			PlayerPrefs.SetInt("morte", qtdmorte+ 1);
		}
	}


	void Vire()
	{
		ladoDireito = !ladoDireito;

		Vector2 novoScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);

		transform.localScale = novoScale;
	}
	public void testenome(string nomenovo)
	{
		nome = nomenovo;
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("chao"))
		{
			solo = true;
			verificacao = 0;
			animator.SetBool("pulo", false);

		}
	}
	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("chao"))
		{
			solo = false;
		}
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("morte"))
		{
			SceneManager.LoadScene(4);
			PlayerPrefs.SetInt("morte", PlayerPrefs.GetInt("morte") + 1);
		}
	}

}