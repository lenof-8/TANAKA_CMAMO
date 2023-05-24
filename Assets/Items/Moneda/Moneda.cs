using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{

    public float points;
    public float timer;
    public float maxtimer = 5f;

    void Update()
    {
        timer += Time.deltaTime; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Moneda"))
        {
            changePoints();
        }
    }

    void changePoints ()
    {
        float a =10;
      
        if (timer >= maxtimer)
        {
            a--;
            maxtimer += 5;
        }
        points += a;
    }
}
