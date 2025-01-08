using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Snowman : MonoBehaviour
{
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            Destroy(gameObject);
        }
    }
}
