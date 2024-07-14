using UnityEngine;

// FastMovement strategy implementation
public class FastMovement : IMovementStrategy
{
    public void Move(Transform transform)
    {
        transform.Translate(Vector3.right * Time.deltaTime * 10f);
    }
}
