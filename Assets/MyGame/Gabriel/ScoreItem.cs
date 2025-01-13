using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public UIManager uiManager; // Reference to UIManager to update the score
    public int Score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Kollision erkannt!");

        // Check if the Rocket collides with a Tree or Snowman
        if (collision.gameObject.CompareTag("Tree"))
        {
            Debug.Log("Baum getroffen! Punkte abgezogen.");
            uiManager.UpdateScore(Score+5); // Adjust score for hitting a Tree
        }
        else if (collision.gameObject.CompareTag("Snowman"))
        {
            Debug.Log("Schneemann getroffen! Punkte hinzugefügt.");
            uiManager.UpdateScore(Score+2); // Adjust score for hitting a Snowman
        }
    }
}
