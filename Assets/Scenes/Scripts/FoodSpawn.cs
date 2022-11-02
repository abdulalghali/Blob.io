using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour //change to Food/FoodSpawner
{
    public GameObject food; //change to food/foodspawner if it doesnt work
    public Transform foodParent;
    public float Speed;

    void Start()
    {
        InvokeRepeating("Generate", 0 /*how long until it starts spawning*/ , Speed  /*how often to spawn*/); //this calls the function infinitely
    }
    void Generate()
    {
        int x = Random.Range(0, Camera.main.pixelWidth); //this was Camera.main.pixelWidth || GetComponent<Camera>().main.pixelWidth
        int y = Random.Range(0, Camera.main.pixelHeight); 
        //this spawns the food anywhere in the main camera in unity

        Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0)); //it was  GetComponent<Camera>().main.ScreenToWorldPoint
        //converts the pixels to world point
        Target.z = 0; //fixes the z axis

        Instantiate(food/*change this to foodspawner if it doesn't work*/, Target, Quaternion.identity, foodParent);
        //this function spawns the food
        // quaternion doesn't allow the food to rotate
    }
}


//{
//    public GameObject food; //change to food/foodspawner if it doesnt work
//public float speed;

//void start()
//{
//    invokerepeating("generate", 0 /*how long until it starts spawning*/ , speed  /*how often to spawn*/); //this calls the function infinitely
//}
//void generate()
//{
//    int x = random.range(0, GetComponent<Camera>().main.pixelwidth);
//    int y = random.range(0, GetComponent<Camera>().main.pixelheight);
//    //this spawns the food anywhere in the main camera in unity

//    vector3 target = GetComponent<Camera>().main.screentoworldpoint(new vector3(x, y, 0));
//    //converts the pixels to world point
//    target.z = 0; //fixes the z axis

//    instantiate(food/*change this to foodspawner if it doesn't work*/, target, quaternion.identity);
//    //this function spawns the food
//    // quaternion doesn't allow the food to rotate
//}
//}