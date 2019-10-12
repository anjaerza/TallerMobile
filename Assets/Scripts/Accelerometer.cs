using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private float speed;
    [SerializeField] private float smooth;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float accel = Input.acceleration.x;

        Vector3 movimiento =new Vector3 (accel, 0f, 0f);

        transform.Translate(movimiento*speed);




    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("obobbobobo");
    }
}
