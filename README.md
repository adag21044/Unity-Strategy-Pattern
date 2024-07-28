# Unity Strategy Pattern

This repository demonstrates a character movement system in Unity, utilizing the Strategy design pattern to switch between different movement behaviors at runtime.

## Project Structure

1. **Character.cs**: Manages the character's movement using a specified strategy.
2. **IMovementStrategy.cs**: Interface for defining movement strategies.
3. **FastMovement.cs**: Implements fast movement behavior.
4. **NormalMovement.cs**: Implements normal movement behavior.
5. **SlowMovement.cs**: Implements slow movement behavior.
6. **GameController.cs**: Handles user input to change the character's movement strategy.

## Usage

### Character.cs
- **Character**: Uses a movement strategy to move. The strategy can be set at runtime.

### IMovementStrategy.cs
- **IMovementStrategy**: Interface that defines the `Move` method for different movement behaviors.

### Movement Strategies
- **FastMovement**: Moves the character quickly.
- **NormalMovement**: Moves the character at a normal speed.
- **SlowMovement**: Moves the character slowly.

### GameController.cs
- **GameController**: Initializes the character with a default movement strategy and changes the strategy based on user input.

