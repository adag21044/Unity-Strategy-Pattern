using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private IMovementStrategy movementStrategy;

    private void Update()
    {
        /*if (movementStrategy != null)
        {
            movementStrategy.Move(transform);
        }*/
        movementStrategy?.Move(transform);
    }

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        movementStrategy = strategy;
    }
}

public interface IMovementStrategy
{
    void Move(Transform transform);
}
