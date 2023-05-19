using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;

    [SerializeField] float bullTimerMax;
    private float bullTimer;
    [SerializeField] float bullGrowSpeed;
    private float bullGrowTimer;
    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        bullTimer += Time.deltaTime;
        bullGrowTimer += Time.deltaTime * bullGrowSpeed;

        if (bullTimer >= bullTimerMax)
            Destroy(this.gameObject);

        this.transform.localScale += (Vector3.up + Vector3.right) * bullGrowTimer;
    }
}
