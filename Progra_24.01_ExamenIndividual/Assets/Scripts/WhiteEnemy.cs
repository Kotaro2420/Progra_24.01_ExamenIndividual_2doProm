using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteEnemy : Enemy
{
    private bool strategyswitch;

    private void Start()
    {
        health = maxHealth;
        estrategiaEnemigo = new StrategyB(transform, speed);
        strategyswitch = false;

    }

    protected override void CambiarStrategy()
    {
        if (strategyswitch == false)
        {
            if (health < maxHealth / 2)
            {
                estrategiaEnemigo = new StrategyA(transform, speed);
                strategyswitch = true;
            }
        }
    }
}
