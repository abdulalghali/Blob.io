using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMover : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += transform.position * (Time.deltaTime * Random.Range(0.0f, 0.0f)); //it was transform.up
        //Foods movement will start up and then move to specified position
        //Time.deltaTime prevents food from teleporting if lagging occurs
        transform.Rotate(Vector3.forward * Random.Range(100000f, 1000000000f) * Random.Range(0.0f, 180.0f));
    }
}