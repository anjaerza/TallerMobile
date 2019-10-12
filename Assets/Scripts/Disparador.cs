using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    [SerializeField] GameObject bala;
    [SerializeField] private float time;
    [SerializeField] private bool onCooldown;
    [SerializeField] private float cooldown;
    [SerializeField]private float elapsedTimeRaf;
    private const float DURACIONR=3;
    private const float DURACIONCOOLDOWN=30;
    private bool rafagaOn;

    public float Cooldown { get => cooldown; set => cooldown = value; }

    // Start is called before the first frame update
    void Start()
    {
        elapsedTimeRaf = 0;
        Cooldown=0;
        time = 0;
        onCooldown = false;
        rafagaOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cooldown > 0)
        {
            onCooldown = true;
            Cooldown -= Time.deltaTime;
        }

        if (Cooldown <= 0)
        {
            Cooldown = 0;
            onCooldown = false;
        }


        Rafaga(elapsedTimeRaf, onCooldown, rafagaOn);


        time = time + Time.deltaTime;
        elapsedTimeRaf += Time.deltaTime;

        if (Input.touchCount>0 && time>0.4) {


            if (Input.touchCount == 3 && onCooldown==false)
            {
                Touch touch3 = Input.GetTouch(2);

                if (touch3.phase == TouchPhase.Began)
                {
                    elapsedTimeRaf = 0;
                    rafagaOn = true;
                   
                }
                

            }

            Touch touch1 = Input.GetTouch(0);

            if (touch1.phase == TouchPhase.Began)
            {
                Instanciar();
                time = 0;
            }
        }
    }

    void Instanciar()
    {
        Instantiate(bala, this.transform);
    }
    void Rafaga(float tiempoTrans,bool onCool, bool on)
    {
        if (on == true)
        { 
            if (onCool == false)
            {
                InvokeRepeating("Instanciar", 0.1f, 0.6f);
                onCooldown = true;
            }

            if (tiempoTrans >= DURACIONR)
            {
                CancelInvoke();
                Cooldown = DURACIONCOOLDOWN;
                rafagaOn = false;
            }
        }
    }
    

    
}
