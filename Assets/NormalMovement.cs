using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMovement : IMovementStrategy
{
    public void Move(Transform transform)
    {
        transform.Translate(Vector3.right * Time.deltaTime * 5f);
    }
}
