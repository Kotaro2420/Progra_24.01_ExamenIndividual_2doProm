using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackEnemy : Enemy
{
    private bool estrategiaCambiada;    

    private void Start()
    {
        health = maxHealth;
        estrategiaEnemigo = new StrategyA(transform, speed);
        estrategiaCambiada = false;

    }

    protected override void CambiarStrategy()
    {
        if(estrategiaCambiada == false) 
        {
            if (health < maxHealth / 2)
            {
                estrategiaEnemigo = new StrategyB(transform,speed);
                estrategiaCambiada = true;
            }
        }
    }
}
