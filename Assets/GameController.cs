// GameController class to handle user input and change character's movement strategy
using UnityEngine;


public class GameController : MonoBehaviour
{
    public Character character;

    private void Start()
    {
        character.SetMovementStrategy(new NormalMovement());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            character.SetMovementStrategy(new NormalMovement());
        }
        else
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            character.SetMovementStrategy(new FastMovement());
            
        }
        else
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            character.SetMovementStrategy(new SlowMovement());
        }
    }
}
