using UnityEngine;

public class BallInteraction : MonoBehaviour
{
    private Ball selectedBall;
    private Vector3 offset;

    private void Update()
    {
        // Detect mouse down to select a ball
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                selectedBall = hit.collider.GetComponent<Ball>();
                if (selectedBall != null)
                {
                    selectedBall.DisplayText(); // Display message based on the ball type
                    
                    // Calculate the offset between the ball's position and the mouse position
                    offset = selectedBall.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(selectedBall.transform.position).z));
                }
            }
        }

        // If a ball is selected and the mouse button is held down, move the ball
        if (Input.GetMouseButton(0) && selectedBall != null)
        {
            // Calculate the new mouse position in world space, preserving the offset
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(selectedBall.transform.position).z);
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(mousePosition) + offset;
            
            // Update the ball's position
            selectedBall.transform.position = newPosition;
        }

        // If space is pressed and a ball is selected, make it jump
        if (Input.GetKeyDown(KeyCode.Space) && selectedBall != null)
        {
            selectedBall.Jump();
        }

        // Release the selected ball when the mouse button is lifted
        if (Input.GetMouseButtonUp(0))
        {
            selectedBall = null;
        }
    }
}
