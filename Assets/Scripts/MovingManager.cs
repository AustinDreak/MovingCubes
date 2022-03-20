using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingManager : MonoBehaviour
{
    public float xDir;
    public float yDir;
    public float zDir;

    public void FixedUpdate()
    {
        transform.Translate(xDir,yDir,zDir, Space.World);
    }
}
