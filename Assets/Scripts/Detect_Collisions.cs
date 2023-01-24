using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Collisions : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
