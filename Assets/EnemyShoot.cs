using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DispararTime(1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disparar()
    {
        Instantiate(bala, transform.position, Quaternion.identity);
    }

    IEnumerator DispararTime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        yield return new WaitForSeconds(Random.Range(5, 10));

        Disparar();

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(20, 30));
            Disparar();
        }
    }
}
