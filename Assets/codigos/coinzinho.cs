using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinzinho : MonoBehaviour
{
    int vale = 5;
    int tinha;
    int total;
    // Start is called before the first frame update
    void Start()
    {

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
            PlayerPrefs.SetInt("dinheiro", tinha + vale);
            PlayerPrefs.SetInt("total", total + vale);
            Destroy(this.gameObject);
        }
    }
}
