using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasboss : MonoBehaviour
{
    Slider barravidaBOSS;
    public boss refboss;
    // Start is called before the first frame update
    void Awake()
    {
        refboss = GameObject.Find("Idle1").GetComponent<boss>();
    }

        void Start()
    {
        barravidaBOSS = this.transform.GetChild(0).gameObject.GetComponent<Slider>();
        barravidaBOSS.maxValue = 500;
    }

    // Update is called once per frame
    void Update()
    {
        barravidaBOSS.value = refboss.vida;
    }
}
