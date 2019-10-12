using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompSuperBala : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float potencia;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.up * potencia);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Toplimit")
        {
            Destroy(this.gameObject);
        }

        if (other != null)
        {
            if (other.GetComponent<Enemy>() != null)
            {
                other.GetComponent<Enemy>().Destruir();
            }
        }
    }
}
