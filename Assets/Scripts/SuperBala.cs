using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SuperBala : MonoBehaviour
{
    [SerializeField] private GameObject superBala;
    [SerializeField] private float cooldown;
    [SerializeField] private bool onCooldown;
    private const float VALCOOLD = 60;
    Vector2 dragI = Vector2.zero;
    Vector2 dragF = Vector2.zero;

    public float Cooldown { get => cooldown; set => cooldown = value; }


    // Start is called before the first frame update
    void Start()
    {
        onCooldown = false;
        Cooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cooldown > 0)
        {
            Cooldown -= Time.deltaTime;
        }

        if (Cooldown <=0)
        {
            Cooldown = 0;
            onCooldown = false;
        }

        if (Input.touchCount > 0)
        {
            Touch touch1 = Input.GetTouch(0);

            if (touch1.phase == TouchPhase.Began)
            { 
                dragI = touch1.position;
                // Debug.Log(dragI);
            }

            if(touch1.phase==TouchPhase.Ended)
            {

                dragF = touch1.position;
                Vector2 swipe = dragF - dragI;

                dragI = Vector2.zero;
                dragF = Vector2.zero;

                if (swipe.y > Camera.main.pixelHeight*1/3 && onCooldown==false)
                {
                    Debug.Log("BADJQENJNBJQNBJENBJNEQBJQEBJ");

                    LanzarSuperBala();
                    Cooldown = VALCOOLD;
                    onCooldown = true;

                }
            }
            
        }
    }


    void LanzarSuperBala()
    {
        Instantiate(superBala, this.transform);
    }
}
