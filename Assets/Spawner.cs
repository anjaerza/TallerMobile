using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject line;
    private int contador;
    private const int NUMBLOQUE=4;
    private bool bloqueGenerado;


    // Start is called before the first frame update
    void Start()
    {
        bloqueGenerado = false;
        contador = 0;
        InvokeRepeating("GenerarLinea", 2, 7);
    }

    // Update is called once per frame
    void Update()
    {
        if (contador >= NUMBLOQUE && bloqueGenerado==false)
        {
            CancelInvoke();
            bloqueGenerado = true;
        }

    }

    public void GenerarLinea()
    {
        GameObject linea= Instantiate(line, transform.position,Quaternion.identity);
        linea.transform.Find("A").Translate(this.transform.position);
        contador++;

    }
}
