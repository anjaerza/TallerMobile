using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    [SerializeField] private int puntaje;
    [SerializeField] private Text texto;
    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;

    }

    // Update is called once per frame
    void Update()
    {
        texto.text = puntaje.ToString();
        
    }

    public void SumarPuntos()
    {
        puntaje++;

    }
    public void SumarPuntos(int val)
    {
        puntaje+=val;

    }
}
