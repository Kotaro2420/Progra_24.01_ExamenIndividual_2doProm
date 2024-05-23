using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IVida
{
    public int health = 100;
    public int maxHealth = 100;
    public float speed = 0.5f;
    protected IStrategy estrategiaEnemigo;


    private void Update()
    {
        CambiarStrategy();
        estrategiaEnemigo.Execute();
    }

    public virtual void RecibirDa�o(int cantidadDa�o)
    {
        health -= cantidadDa�o;
        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }

    protected abstract void CambiarStrategy();
}
