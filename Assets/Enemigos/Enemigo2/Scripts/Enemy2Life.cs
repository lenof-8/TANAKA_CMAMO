using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Life : MonoBehaviour
{
    EnemiesLife eLife;
    [SerializeField] float lifeGrowSpeed;
    private float lifeGrowTimer;
    void Awake()
    {
        eLife = this.GetComponent<EnemiesLife>();
    }

    void Update()
    {
        lifeGrowTimer += Time.deltaTime * lifeGrowSpeed;
        eLife.life += lifeGrowTimer;
    }
}
