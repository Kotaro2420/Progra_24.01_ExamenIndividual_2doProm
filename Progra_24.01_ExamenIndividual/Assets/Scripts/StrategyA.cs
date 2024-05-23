using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyA : IStrategy
{
    private Transform _transform;
    private float moveSpeed;
    public StrategyA(Transform transform, float moveSpeed)
    {
        this._transform = transform;
        this.moveSpeed = moveSpeed;
    }

    public void Execute()
    {

        _transform.Translate(moveSpeed * Time.deltaTime * Vector2.down * 10);
    }
}
