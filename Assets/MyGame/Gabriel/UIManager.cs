using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText; // Reference to the TextMeshPro text element
    private int playerScore = 0; // The player's score

    // Method to update the score and UI
    public void UpdateScore(int amount)
    {
        playerScore += amount;
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
