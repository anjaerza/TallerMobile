using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
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
        if (collision.gameObject.tag == "BalaPlayer")
        {
            AudioSource.PlayClipAtPoint(clip, transform.position,0.85f);
            Destruir();
        }
    }

    public void Destruir()
    {
        if (puntos.GetComponent<Puntaje>() != null)
        {
            if (destruido == false)
            {
                puntos.GetComponent<Puntaje>().SumarPuntos();
                destruido = true;
                Destroy(this.gameObject);
            }
        }
    }
}
