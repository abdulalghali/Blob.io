using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GVirusSpawn : MonoBehaviour 
{
    //public GameObject GreenVirus;
    //public Transform virusParent;
    //public float Speed;

    //void Start()
    //{
    //    InvokeRepeating("Generate", 0, Speed  ); //this calls the function infinitely
    //}
    //void Generate()
    //{
    //    int x = Random.Range(0, Camera.main.pixelWidth); 
    //    int y = Random.Range(0, Camera.main.pixelHeight);
    //    //this spawns the food anywhere in the main camera in unity

    //    Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0)); 
    //    Target.z = 0; //fixes the z axis

    //    Instantiate(GreenVirus, Target, Quaternion.identity, virusParent);
    //}
    public GameObject v; //change to food/foodspawner if it doesnt work
    public Transform foodParent;
    public float Speed;

    void Start()
    {
        InvokeRepeating("Generate", 0 /*how long until it starts spawning*/ , Speed  /*how often to spawn*/); //this calls the function infinitely
    }
    void Generate()
    {
        int x = UnityEngine.Random.Range(0, Camera.main.pixelWidth); //this was Camera.main.pixelWidth || GetComponent<Camera>().main.pixelWidth
        int y = UnityEngine.Random.Range(0, Camera.main.pixelHeight);
        //this spawns the food anywhere in the main camera in unity

        Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0)); //it was  GetComponent<Camera>().main.ScreenToWorldPoint
        //converts the pixels to world point
        Target.z = 0; //fixes the z axis

        Instantiate(v/*change this to foodspawner if it doesn't work*/, Target, Quaternion.identity, foodParent);
        //this function spawns the food
        // quaternion doesn't allow the food to rotate
    }
}