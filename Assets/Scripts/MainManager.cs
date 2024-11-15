using UnityEngine;
using TMPro;

public class MainManager : MonoBehaviour
{
    public TMP_Text playerNameText; // Reference to the text component for displaying the name

    private void Start()
    {
        // Display the player's name stored in GameData
        playerNameText.text = "Welcome, Player: " + GameData.playerName + "!";
    }
}
