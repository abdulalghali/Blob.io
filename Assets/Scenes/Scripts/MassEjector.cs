using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MassEjector : MonoBehaviour
{
    //public Transform FirePoint;
    //public GameObject MassBlob;
    //public float Decrease;
    //private int Score = 0;
    //public Text Letters;

    //void Update()
    //{

    //    if (Input.GetButtonDown("Fire1"))
    //    //every time the shoot button is pressed, the shoot function will be called
    //    {
    //        Shoot();
    //        transform.localScale -= new Vector3(Decrease, Decrease, Decrease);
    //        Score -= 10;
    //        Letters.text = "SCORE: " + Score;
    //    }
    //}

    //void Shoot() //executes when shoot button is called
    //{
    //    //this is the mass ejector function
    //    Instantiate(MassBlob, FirePoint.position/*where to spawn*/, FirePoint.rotation);
    //}
}
//    public GameObject player;
//    public GameObject MassBlob;
//    public GameObject FirePoint;

//    public float Speed = 10.0f;

//    private Vector3 target;

//    void Update()
//    {
//        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

//        Vector3 difference = target - player.transform.position;
//        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
//        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

//        if (Input.GetButtonDown("Fire1"))
//        {
//            float distance = difference.magnitude;
//            Vector2 direction = difference / distance;
//            direction.Normalize();
//            fireBullet(direction, rotationZ);
//        }
//    }
//    void fireBullet(Vector2 direction, float rotationZ)
//    {
//        GameObject b = Instantiate(MassBlob);// as GameObject;
//        b.transform.position = FirePoint.transform.position;
//        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
//        b.GetComponent<Rigidbody2D>().velocity = direction * Speed;
//    }
//}
