using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    public MovingManager MoveManager;
    public GameObject cubePrefab;

    public float timer = 0.0f;
    public float timeToRespawn = 1f;
    public float speed;
 
    public GameObject[] allCubes;

    public InputField inputFieldTTR;
    public InputField inputFieldSpeed;

    void Start()
    {
        timer = Time.time;
    }

    void Update()
    {
        if (Time.time - timer > timeToRespawn)
        {
            SpawnCube();
            timer = Time.time;
        }
    }

    private void FixedUpdate()
    {
        allCubes = GameObject.FindGameObjectsWithTag("Cubes");
        if (allCubes != null)
        {
            foreach (GameObject clone in allCubes)
            {
                MoveManager.xDir = speed;
            }
        }
    }

    private void OnEnable()
    {
        inputFieldTTR.onEndEdit.AddListener(OnTTREdited);
        inputFieldSpeed.onEndEdit.AddListener(OnSpeedEdited);
    }

    private void OnDisable()
    {
        inputFieldTTR.onEndEdit.RemoveListener(OnTTREdited);
        inputFieldSpeed.onEndEdit.RemoveListener(OnSpeedEdited);
    }

    private void OnTTREdited(string newText)
    {
        timeToRespawn = float.Parse(newText);
    }

    private void OnSpeedEdited(string newText)
    {
        speed = float.Parse(newText);
    }

    private void SpawnCube()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        GameObject cubeClone = Instantiate(cubePrefab, spawnPosition, Quaternion.identity) as GameObject;
        Debug.Log("Cube created");
    }
}

