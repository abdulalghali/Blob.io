using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;


    //void Update()
    //{
    //    OnTriggerEnter()
    //}
    void OnTriggerEnter(Collider other) // Any object that the cell collides with
    {
        if (other.gameObject == Enemy1 && transform.localScale.x > Enemy1.transform.localScale.x)
        {
            transform.localScale += new Vector3(Enemy1.transform.localScale.x, Enemy1.transform.localScale.x, Enemy1.transform.localScale.x);
            Destroy(other.gameObject);
        }
        else if (other.gameObject == Enemy1 && transform.localScale.x < Enemy1.transform.localScale.x)
        {
            Destroy(Player.gameObject);
        }
        if (other.gameObject == Enemy2 && transform.localScale.x > Enemy2.transform.localScale.x)
        {
            transform.localScale += new Vector3(Enemy2.transform.localScale.x, Enemy2.transform.localScale.x, Enemy2.transform.localScale.x);
            Destroy(other.gameObject); 
        }
        else if (other.gameObject == Enemy2 && transform.localScale.x < Enemy2.transform.localScale.x)
        {
            Destroy(Player.gameObject);
        }
        if (other.gameObject == Enemy3 && transform.localScale.x > Enemy3.transform.localScale.x)
        {
            transform.localScale += new Vector3(Enemy3.transform.localScale.x, Enemy3.transform.localScale.x, Enemy3.transform.localScale.x);
            Destroy(other.gameObject); 
        }
        else if (other.gameObject == Enemy3 && transform.localScale.x < Enemy3.transform.localScale.x)
        {
            Destroy(Player.gameObject);
        }
        if (other.gameObject == Enemy4 && transform.localScale.x > Enemy4.transform.localScale.x)
        {
            transform.localScale += new Vector3(Enemy4.transform.localScale.x, Enemy4.transform.localScale.x, Enemy4.transform.localScale.x);
            Destroy(other.gameObject); 
        }
        else if (other.gameObject == Enemy4 && transform.localScale.x < Enemy4.transform.localScale.x)
        {
            Destroy(Player.gameObject);
        }
        if (other.gameObject == Enemy5 && transform.localScale.x > Enemy5.transform.localScale.x)
        {
            transform.localScale += new Vector3(Enemy5.transform.localScale.x, Enemy5.transform.localScale.x, Enemy5.transform.localScale.x);
            Destroy(other.gameObject); 
        }
        else if (other.gameObject == Enemy5 && transform.localScale.x < Enemy5.transform.localScale.x)
        {
            Destroy(Player.gameObject);
        }
        if (other.gameObject == Enemy6 && transform.localScale.x > Enemy6.transform.localScale.x)
        {
            transform.localScale += new Vector3(Enemy6.transform.localScale.x, Enemy6.transform.localScale.x, Enemy6.transform.localScale.x);
            Destroy(other.gameObject);
        }
        else if (other.gameObject == Enemy6 && transform.localScale.x < Enemy6.transform.localScale.x)
        {
            Destroy(Player.gameObject);
        }
        if (other.gameObject == Enemy7 && transform.localScale.x > Enemy7.transform.localScale.x)
        {
            transform.localScale += new Vector3(Enemy7.transform.localScale.x, Enemy7.transform.localScale.x, Enemy7.transform.localScale.x);
            Destroy(other.gameObject);
        }
        else if (other.gameObject == Enemy7 && transform.localScale.x < Enemy7.transform.localScale.x)
        {
            Destroy(Player.gameObject);
        }
        if (other.gameObject == Enemy8 && transform.localScale.x > Enemy8.transform.localScale.x)
        {
            transform.localScale += new Vector3(Enemy8.transform.localScale.x, Enemy8.transform.localScale.x, Enemy8.transform.localScale.x);
            Destroy(other.gameObject);
        }
        else if (other.gameObject == Enemy8 && transform.localScale.x < Enemy8.transform.localScale.x)
        {
            Destroy(Player.gameObject);
        }
    }
}

    //private GameObject go;
    //private GameObject gotwo;

    //void Start()
    //{
    //    go.tag = ("Player");
    //    gotwo.tag = ("Enemy");
    //}


    //void OnTriggerEnter(Collider other)
    //{

    //    Enemy enemy = other.GetComponent<Enemy>();
    //    if (enemy != null)
    //    {
    //        //Debug.Log(hitInfo.name);

    //        if (go.transform.localScale.magnitude > enemy.transform.localScale.magnitude)
    //        {
    //            //Debug.Log("Bigger");
    //            Destroy(gotwo.gameObject);
    //        }
    //        else if (go.transform.localScale.magnitude < enemy.transform.localScale.magnitude)
    //        {
    //            //Debug.Log("Smaller");
    //            Destroy(go.gameObject);
    //        }
    //    }
    //}




//private float Increase = gameObject.transform.localScale;
//public string Tag;


//void OnTriggerEnter(Collider other) // Any object that the cell collides with
//{
//    if (other.gameObject.tag == Tag && transform.localScale.x > gameObject.transform.localScale.x && transform.localScale.y > gameObject.transform.localScale.y)
//    {
//        transform.localScale += new Vector3(Increase, Increase, Increase); //increases size of players cell
//        Destroy(other.gameObject); //destroys the food object
//    }

//}
