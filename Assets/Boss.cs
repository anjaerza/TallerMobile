using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private GameObject puntos;
    private bool destruido;
    [SerializeField] private AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        puntos = GameObject.Find("Canvas");
        destruido = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position,1f);
        Destruir();
    }

    public void Destruir()
    {
        if (puntos.GetComponent<Puntaje>() != null)
        {
            if (destruido == false)
            {
                puntos.GetComponent<Puntaje>().SumarPuntos(10);
                destruido = true;
                Destroy(this.gameObject);
            }
        }
    }

    void Fin()
    {
        Destroy(this.gameObject);
    }

}
