using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    // ENCAPSULATION - Private data members with public properties
    private float bounceFactor;
    private string ballColor;
    private float size;
    private float weight;

    // Jump control variables
    protected bool canJump = true; // To control jump cooldown
    protected float jumpCooldown = 1.0f; // Cooldown time in seconds

    // Properties with validation for encapsulation
    public float BounceFactor
    {
        get { return bounceFactor; }
        set
        {
            if (value >= 0.1f && value <= 1.0f)
                bounceFactor = value;
            else
                Debug.LogError("BounceFactor must be between 0.1 and 1.0.");
        }
    }

    public string BallColor
    {
        get { return ballColor; }
        set { ballColor = value; }
    }

    public float Size
    {
        get { return size; }
        set
        {
            if (value > 0)
                size = value;
            else
                Debug.LogError("Size must be greater than 0.");
        }
    }

    public float Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
                weight = value;
            else
                Debug.LogError("Weight must be greater than 0.");
        }
    }

    // POLYMORPHISM - Abstract Jump method to be implemented by subclasses
    public abstract void Jump();

    // ABSTRACTION - High-level reusable function for interaction
    public void Interact(Vector2 mousePosition)
    {
        transform.position = mousePosition;
    }

    // ABSTRACTION - Display message based on ball type
    public abstract void DisplayText();
}
