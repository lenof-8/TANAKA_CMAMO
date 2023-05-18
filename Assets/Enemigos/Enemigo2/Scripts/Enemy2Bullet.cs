using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;

    [SerializeField] float bullTimerMax;
    private float bullTimer;
    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        bullTimer += Time.deltaTime;

        if (bullTimer >= bullTimerMax)
            Destroy(this.gameObject);
    }
}
