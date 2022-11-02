using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public string Tag;
    public float Increase;
    public Text Letters;
    private int Score = 0;
    public Transform FirePoint;
    public GameObject MassBlob;
    public float Decrease;

    void OnTriggerEnter(Collider other) // Any object that the cell collides with
    {
        if (other.gameObject.tag == Tag) // checks which object it collided with
        {
            transform.localScale += new Vector3(Increase, Increase, Increase); //increases size of players cell
            Destroy(other.gameObject); //destroys the food object
            Score += 10;
            Letters.text = "SCORE: " + Score;
        }

    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        //every time the shoot button is pressed, the shoot function will be called
        {
            Shoot();
            transform.localScale -= new Vector3(Decrease, Decrease, Decrease);
            Score -= 10;
            Letters.text = "SCORE: " + Score;
        }
    }

    void Shoot() //executes when shoot button is called
    {
        //this is the mass ejector function
        Instantiate(MassBlob, FirePoint.position/*where to spawn*/, FirePoint.rotation);
    }
}