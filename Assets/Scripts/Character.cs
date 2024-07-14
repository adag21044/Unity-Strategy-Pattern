using System;
using UnityEngine;

// Character class that uses a movement strategy to move
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

    // Method to set the movement strategy at runtime
    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        movementStrategy = strategy;
    }
}

// Interface for movement strategies
public interface IMovementStrategy
{
    void Move(Transform transform);
}
