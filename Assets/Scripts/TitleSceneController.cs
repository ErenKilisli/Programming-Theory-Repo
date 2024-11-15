using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Required if using TextMeshPro for InputField and Text

public class TitleSceneController : MonoBehaviour
{
    public TMP_InputField nameInputField; // Reference to the input field for player's name

    // Method called when the Start button is pressed
    public void OnStartButtonPressed()
    {
        // Store the player's name in GameData
        GameData.playerName = nameInputField.text;

        // Load the Main Scene
        SceneManager.LoadScene("MainScene");
    }
}

