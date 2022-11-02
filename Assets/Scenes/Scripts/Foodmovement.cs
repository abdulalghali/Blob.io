using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foodmovement : MonoBehaviour
{
}




//public GameObject GameArea;
//public GameObject Food;

//public int food_count = 0;
//public int food_limit = 1000; //how many food pieces can exist at one time
//public int foods_per_frame = 1; // how many food will be created every time its run

//public float spawn_circle_radius = 150.0f;
//public float death_circle_radius = 160.0f;

//public float fastest_speed = 20.0f;
//public float slowest_speed = 1.0f;

//    void Start()
//    {
//        InitialPopulation(); // creating an initial population as soon as the game starts
//    }

//    void InitialPopulation()
//    {
//        for (i = 0; i < food_limit; i++) 
//     // to avoid waiting for foods to enter the game screen at start up, this creates an initial number of foods already in screen
//        {
//            Vector3 position = GetRandomPosition(true); //when the game starts the food will be spawned in game
//            SCR_Food Food_script = AddFood(position);
//            Food_script.transform.Rotate(Vector3.forward * Random.Range(0.0f, 360.0f));
//            //when the game starts, the food move in a random direction
//        }
//    }

//    void Update()
//    {
//        MaintainPopulation(); //calls this every frame
//    }

//    void MaintainPopulation()
//    {
//        if (food_count < food_limit)
//        // if the number of food drops below the limit then it is brought back up
//        {
//            for (i = 0; i < foods_per_frame; i++)
//            {
//                Vector3 position = GetRandomPosition(false); //when the game is running the food wont spawn in game
//                SCR_Food Food_script = AddFood(position); 
//                Food_script.transform.Rotate(Vector3.forward * Random.Range(-45.0f, 45.0f)); //rotates food on the z-axis between -45 and 45 degrees
//                //when the game is running, the food spawns on the outer edge of the map and generally moves towards the centre
//            }
//        }
//    }

//    Vector3 GetRandomPosition(bool within_camera) //gets a position within the camera view
//    {
//        Vector3 position = Random.insideUnitCircle;
//        //gets a random position in the  circle
//        if (within_camera == false) 
//        {
//            position = position.normalized;
//        }

//        position += spawn_circle_radius; //magnifies the random position to be scaled as the specified circle radius
//        position += game_area.transform.position;

//        return position;
//    }

//    SCR_Food AddFood(Vector3 position)
//    {
//        Food_count += 1;
//        GameObject new_Food = Instantiate
//            (
//            Food_prefab,
//            position,
//            Quaternion.FromToRotation(Vector3.up, (game_area.transform.position - position)),
//            gameObject.transform
//            //where to rotate from then rotate to
//            //it goes from looking up to looking to centre of game area - a random position number
//            );

//        SCR_Food Food_script = new_Food.GetComponent<SCR_Food>(); //
//        Food_script.Food_spawner = this; //the Food script can now access this script
//        Food_script.game_area = game_area; //the Food has access to the game area
//        Food_script.speed = Random.Range(slowest_speed, fastest_speed);

//        return Food_script; //this means exit the function and take along Food_script
//    }
