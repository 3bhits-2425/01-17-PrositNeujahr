using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCounter : MonoBehaviour
{
    // Z�hler f�r Schneem�nner und Christb�ume
    public int snowmanCount = 0;
    public int treeCount = 0;

    // Wird aufgerufen, wenn ein Objekt zerst�rt wird
    public void OnObjectDestroyed(GameObject obj)
    {
        // Pr�fen, ob das Objekt ein Schneemann oder ein Christbaum ist
        if (obj.CompareTag("Snowman"))
        {
            snowmanCount++;
            Debug.Log("Schneemann zerst�rt! Z�hler: " + snowmanCount);
        }
        else if (obj.CompareTag("Tree"))
        {
            treeCount++;
            Debug.Log("Christbaum zerst�rt! Z�hler: " + treeCount);
        }
    }
}
