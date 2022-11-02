using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public Transform enemyParent;
    public float Speed;

    void Start()
    {
            InvokeRepeating("Generate", 0, Speed);
    }
    void Generate()
    {
        int x = Random.Range(0, Camera.main.pixelWidth);
        int y = Random.Range(0, Camera.main.pixelHeight);
        //this spawns the food anywhere in the main camera in unity

        Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));
        Target.z = 0; //fixes the z axis

        Instantiate(Enemy, Target, Quaternion.identity, enemyParent);
    }
}