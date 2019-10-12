using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hilera : MonoBehaviour
{
    private GameObject[] enemigos;
    [SerializeField] private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] transforms = this.GetComponentsInChildren<Transform>();

        foreach(Transform transform in transforms)
        {
            transform.gameObject.GetComponentInChildren<SpriteRenderer>().sprite = sprite;
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            GameObject.Find("Spawner").GetComponent<Spawner>().GenerarLinea();
            Destroy(this.transform.parent.parent.gameObject);
        }
    }
}
