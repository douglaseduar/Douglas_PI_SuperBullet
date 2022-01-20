using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
          Vector3 mov = new Vector3(8, 0, 0);
            transform.Translate(mov * Time.deltaTime);
            Destroy(this.gameObject, 1f);
     
    }
}

