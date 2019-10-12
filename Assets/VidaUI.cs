using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaUI : MonoBehaviour
{
    [SerializeField] private int vida;
    [SerializeField] private Text texto;
    // Start is called before the first frame update
    void Start()
    {
        vida = GameObject.Find("Player").GetComponent<PlayerHealth>().VidaActual;
        texto.text ="Vidas\n"+vida;

    }

    // Update is called once per frame
    void Update()
    {

        vida = GameObject.Find("Player").GetComponent<PlayerHealth>().VidaActual;
        texto.text = "Vidas\n" + vida;


    }
}
