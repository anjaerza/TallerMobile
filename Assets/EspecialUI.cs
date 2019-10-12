using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EspecialUI : MonoBehaviour
{
    [SerializeField] private float coolDown;
    [SerializeField] private Text texto;
    // Start is called before the first frame update
    void Start()
    {
        coolDown = GameObject.Find("Player").GetComponent<SuperBala>().Cooldown;
        texto.text = "D.Especial\nListo";

    }

    // Update is called once per frame
    void Update()
    {

        coolDown = GameObject.Find("Player").GetComponent<SuperBala>().Cooldown;

        if (coolDown <= 0)
        {
            texto.text = "D.Especial\nListo";

        }
        else
        {

            texto.text = "D.Especial\n" + Mathf.RoundToInt(coolDown) + "s";
        }


    }
}
