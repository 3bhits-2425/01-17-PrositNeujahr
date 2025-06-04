using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCounter : MonoBehaviour
{
    // Zähler für Schneemänner und Christbäume
    public int snowmanCount = 0;
    public int treeCount = 0;

    // Wird aufgerufen, wenn ein Objekt zerstört wird
    public void OnObjectDestroyed(GameObject obj)
    {
        // Prüfen, ob das Objekt ein Schneemann oder ein Christbaum ist
        if (obj.CompareTag("Snowman"))
        {
            snowmanCount++;
            Debug.Log("Schneemann zerstört! Zähler: " + snowmanCount);
        }
        else if (obj.CompareTag("Tree"))
        {
            treeCount++;
            Debug.Log("Christbaum zerstört! Zähler: " + treeCount);
        }
    }
}
