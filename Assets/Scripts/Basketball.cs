using UnityEngine;
using System.Collections;

public class Basketball : Ball // INHERITANCE
{
    private void Start()
    {
        BallColor = "Orange";
        Size = 0.6f;
        BounceFactor = 0.7f;
        Weight = 0.65f;
    }

public override void Jump() // POLYMORPHISM
{
    if (canJump)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Apply a lower upward force to keep the ball from flying out of the scene
            rb.AddForce(Vector3.up * BounceFactor * 10, ForceMode.Impulse); // Adjusted force
            canJump = false;
            StartCoroutine(JumpCooldownCoroutine()); // Start cooldown
        }
    }
}


    public override void DisplayText() // POLYMORPHISM
    {
        Debug.Log("Dribble and dunk!");
    }

    // Cooldown coroutine to reset jump ability
    private IEnumerator JumpCooldownCoroutine()
    {
        yield return new WaitForSeconds(jumpCooldown); // Wait for cooldown time
        canJump = true; // Allow jumping again
    }
}
