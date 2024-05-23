using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyB : IStrategy
{
    private Transform _transform;
    private float moveSpeed;
    public StrategyB(Transform transform, float moveSpeed)
    {
        this._transform = transform;
        this.moveSpeed = moveSpeed;
    }

    public void Execute()
    {

        _transform.Translate(moveSpeed * Time.deltaTime * Vector2.down);
    }


}
