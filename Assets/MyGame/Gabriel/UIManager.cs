// UIManager-Skript: Unverändert, außer dass es zentral Punkte verwaltet
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText; // UI-Textfeld für den Score
    public int score;     // Der aktuelle Score

    // Methode zum Aktualisieren des Scores
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd; // Punkte hinzufügen
        Debug.Log("Score: " + score); // Im Log anzeigen
        scoreText.text = "Score: " + score; // Im UI anzeigen
        Debug.Log("Score angezeigt");
    }

    private void Update()
    {
        if (score >= 10)
        {
            SceneManager.LoadScene("Demo");
        }
    }
}
