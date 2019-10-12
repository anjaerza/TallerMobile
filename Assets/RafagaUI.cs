using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RafagaUI : MonoBehaviour
{
    [SerializeField] private float coolDown;
    [SerializeField] private Text texto;
    // Start is called before the first frame update
    void Start()
    {
        coolDown = GameObject.Find("Player").GetComponent<Disparador>().Cooldown;
        texto.text = "Ráfaga\nLista";

    }

    // Update is called once per frame
    void Update()
    {

        coolDown = GameObject.Find("Player").GetComponent<Disparador>().Cooldown;

        if (coolDown <= 0)
        {
            texto.text = "Ráfaga\nLista";

        }
        else
        {

            texto.text = "Ráfaga\n"+ Mathf.RoundToInt(coolDown) + "s";
        }
        

    }


}
