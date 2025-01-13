using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public UIManager uiManager; // Referenz auf den UIManager

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        // Prüfen, ob die Rakete einen "Tree" oder "Snowman" trifft
        if (collision.gameObject.tag == "Tree")
        {
            Debug.Log("Tree getroffen! Punkte: 5");
            uiManager.UpdateScore(5); // 5 Punkte für einen Tree
        }
        else if (collision.gameObject.tag == "Snowman")
        {
            Debug.Log("Snowman getroffen! Punkte: 2");
            uiManager.UpdateScore(2); // 2 Punkte für einen Snowman
        }
    }
}
