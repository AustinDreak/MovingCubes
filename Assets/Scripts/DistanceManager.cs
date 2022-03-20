using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceManager : MonoBehaviour
{
    public InputField inputFieldX;

    private void OnEnable()
    {
        inputFieldX.onEndEdit.AddListener(OnDistEdited);
    }

    private void OnDisable()
    {
        inputFieldX.onEndEdit.RemoveListener(OnDistEdited);
    }

    private void OnDistEdited(string newText)
    {
        Vector3 newPosition = transform.position;
        newPosition.x = float.Parse(newText);
        transform.position = newPosition;
    }
}
