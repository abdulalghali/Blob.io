using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusEat : MonoBehaviour
{
    public string Tag;
    //public float Increase;
    public float Increase2;

    void OnTriggerEnter(Collider other) // Any object that the cell collides with
    {
        if (other.gameObject.tag == Tag && transform.localScale.x >= 2.5 && transform.localScale.y >= 2.5) // checks if it collides with virus adn size is 2.5 or greater
        {
            transform.localScale += new Vector3(Increase2, Increase2, Increase2);//increases size of players cell

            Destroy(other.gameObject); //destroys the Virus object
        }

        //TODO: create max limit of viruses
    }
}