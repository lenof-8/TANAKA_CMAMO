using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cura : MonoBehaviour
{

    public PlayerStats pstats;
    public float timer;
    public float maxtimer = 5f;

    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cura"))
        {
            changePoints();
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trampa"))
        {
            pstats._pLife -= 10;
        }
    }
    
    void changePoints()
    {
        float a = 30;

        if (timer >= maxtimer)
        {
            a-= 5f;
            maxtimer += 3f;
        }
        pstats._pLife += a;
    }
}
