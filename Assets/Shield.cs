using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private int impactos;
    private const int MAXIMPACTOS = 10;
    // Start is called before the first frame update
    void Start()
    {
        impactos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (impactos >= MAXIMPACTOS)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        impactos++;
        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(this.gameObject);
        }

     
    }
}
