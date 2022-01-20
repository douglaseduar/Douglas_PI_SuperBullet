using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinzinho : MonoBehaviour
{
    int vale = 5;
    int tinha;
    int total;
    public AudioClip sommoeda;
    private AudioSource audioS1;
    // Start is called before the first frame update
    void Start()
    {
        audioS1 = this.GetComponent<AudioSource>();
        audioS1.clip = sommoeda;
    }

    // Update is called once per frame
    void Update()
    {
        tinha = PlayerPrefs.GetInt("dinheiro");
        total = PlayerPrefs.GetInt("total");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioS1.Play();
            PlayerPrefs.SetInt("dinheiro", tinha + vale);
            PlayerPrefs.SetInt("total", total + vale);
            Destroy(this.gameObject, 0.4f);
           
        }
    }
}
