using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public int points = 5; // Punkte, die dieses Objekt wert ist
    private UIManager uiManager; // Referenz auf den UIManager

    private void Start()
    {
        // Den UIManager in der Szene finden
        uiManager = FindObjectOfType<UIManager>();
        if (uiManager == null)
        {
            Debug.LogError("UIManager nicht gefunden!");
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        // Prüfen, ob die Rakete das Objekt trifft
        if (collision.gameObject.tag == "Rocket")
        {
            Debug.Log(gameObject.name + " getroffen! Punkte: " + points);

            // Punkte zum Score hinzufügen
            uiManager.UpdateScore(points);

            // Optional: Objekt zerstören, nachdem es getroffen wurde
            Destroy(gameObject);
        }
    }
}
