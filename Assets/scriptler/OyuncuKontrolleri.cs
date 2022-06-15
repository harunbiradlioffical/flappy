using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrolleri : MonoBehaviour
{
    // Start is called before the first frame update
    public float ucusGucu;
    private Rigidbody2D rigiBody;
    public bool oyunBasladi;
    public bool oyunBitti;

    void Start()
    {
        rigiBody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        if(Input.GetButtonDown("Fire1") && oyunBasladi == false)
        {
            if (!oyunBasladi)
            {
                rigiBody.gravityScale = 1;
                oyunBasladi = true;
                Uc();
            }
        }
    }
    void Uc()
    {
        rigiBody.velocity = Vector2.zero;
        rigiBody.AddForce(new Vector2(0,ucusGucu));
    }
    void OnTriggerEnter2D(Collider2D diger)
    {
        if (diger.tag=="OlumAlani") {
            oyunBitti = true;
        }
    }
    void OnCollisionEnter2D(Collider2D diger)
    {
        if (diger.transform.tag == "OlumAlani")
        {
            oyunBitti = true;
        }
    }
}

