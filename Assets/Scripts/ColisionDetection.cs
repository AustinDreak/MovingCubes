using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDetection : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Target"))
        {
            Destroy(gameObject);
            Debug.Log("And destroyed");
        }
    }
}
