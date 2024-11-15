using UnityEngine;

public class Football : Ball // INHERITANCE
{
    private void Start()
    {
        // Initialize unique properties
        BallColor = "Black and White";
        Size = 0.7f;
        BounceFactor = 0.4f;
        Weight = 0.9f;
    }

    public override void Jump() // POLYMORPHISM
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.up * BounceFactor * 5, ForceMode.Impulse);
        }
    }

    public override void DisplayText() // POLYMORPHISM
    {
        Debug.Log("Kick me to score!");
    }
}
