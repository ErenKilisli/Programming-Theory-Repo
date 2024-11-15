using UnityEngine;

public class TennisBall : Ball // INHERITANCE
{
    private void Start()
    {
        // Initialize unique properties
        BallColor = "Green";
        Size = 0.3f;
        BounceFactor = 0.9f;
        Weight = 0.3f;
    }

    public override void Jump() // POLYMORPHISM
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.up * BounceFactor * 10, ForceMode.Impulse);
        }
    }

    public override void DisplayText() // POLYMORPHISM
    {
        Debug.Log("Let’s play a match!");
    }
}
