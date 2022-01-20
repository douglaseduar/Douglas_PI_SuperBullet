using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trofeu : MonoBehaviour
{
    int tinha;
    public AudioClip sommoeda;
    private AudioSource audioS;
    // Start is called before the first frame update
    void Start()
    {
        audioS = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        tinha = PlayerPrefs.GetInt("trofeu");
        audioS.clip = sommoeda;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioS.Play();
            PlayerPrefs.SetInt("trofeu", tinha + 1);
            Destroy(this.gameObject, 0.4f);
            
        }
    }
}
