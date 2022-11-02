using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GVirusResponse : MonoBehaviour
{
    private int num = 0;
    public string Tag;
    public float Increase;
    public Transform MassBlobRotation;
    public GameObject Massblob;
    public float Speed;
    public Rigidbody rb;

    void Update()
    {
        void OnTriggerEnter(Collider other) // Any object that the cell collides with
        {
            if (other.gameObject.tag == Tag) // checks which object it collided with
            {
                transform.localScale += new Vector3(Increase, Increase, Increase); //increases size of players cell
                Destroy(other.gameObject); //destroys the food object
                num++;
                if (num == 7)
                {
                    Instantiate(Massblob, other.transform.position, MassBlobRotation.rotation);
                    rb.velocity = transform.position * Speed;
                }
            }
        }
    }
}
