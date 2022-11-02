using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float Speed =10;
    public string Tag;

    void Update()
    {
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z;


        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime / transform.localScale.x);
    }


}
        //void OnCollisionEnter(Collider other)
        //{
        //    if (GetComponent<Collider.other>() == "Border")
        //    {
        //        Speed = 0;
        //    }
        //}

        //if ((transform.position.x = 10) || (transform.position.y = 10))
        //{
        //    Speed = 0;
        //}

        //transform.Translate(Speed * Target.x, Speed * Target.y, 0);

//        if ((transform.position.x <= 10.0f /*&& input.x == -1 */) || (transform.position.x >= 10.0f /*&& input.x == 1*/))
//        {
//            Speed = 0;
//        }

//        if ((transform.position.y <= 10.0f/* && input.x == -1*/) || (transform.position.y >= 10.0f/* && input.y == 1*/))
//        {
//            Speed = 0;
//        }

//        void Update()
//        {

//            Speed = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

//            transform.position += new Vector3(Speed * input.x, Speed * input.y, 0);


//            transform.position += new Vector3(Speed * input.x, Speed * input.y, 0);
//        }
//    }
//}






//TODO: the distance from cell to cursor determines speed


/*if (Input.GetKey(KeyCode.LeftArrow))
{
    transform.position += Vector3.left * Speed * Time.deltaTime;
}
if (Input.GetKey(KeyCode.RightArrow))
{
    transform.position += Vector3.right * Speed * Time.deltaTime;
}
if (Input.GetKey(KeyCode.UpArrow))
{
    transform.position += Vector3.up * Speed * Time.deltaTime;
}
if (Input.GetKey(KeyCode.DownArrow))
{
    transform.position += Vector3.down * Speed * Time.deltaTime;
}*/
//this code is for arrow keys