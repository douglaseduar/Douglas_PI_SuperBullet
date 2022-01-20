using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trofeu : MonoBehaviour
{
    int tinha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tinha = PlayerPrefs.GetInt("trofeu");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("trofeu", tinha + 1);
            Destroy(this.gameObject);
        }
    }
}
