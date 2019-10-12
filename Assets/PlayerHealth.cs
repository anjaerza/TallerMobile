using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private const int MAXHEALTH = 5;
    [SerializeField] private int vidaActual;
    [SerializeField] private string escena;

    public int VidaActual { get => vidaActual; set => vidaActual = value; }

    // Start is called before the first frame update
    void Start()
    {
        VidaActual = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(VidaActual<=0)
        {
            Debug.Log("MUERTO");
            SceneManager.LoadScene(escena);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        VidaActual--;
    }
}
