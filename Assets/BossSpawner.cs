using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    [SerializeField] private GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawnear(15));
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void Instanciar()
    {
        Instantiate(boss, transform.position, Quaternion.identity);
    }

    IEnumerator Spawnear(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Instanciar();

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(40, 60));
            Instanciar();
        }
    }
}
