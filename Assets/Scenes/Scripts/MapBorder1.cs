using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBorder1 : MonoBehaviour
{
    public float Speed;

    public GameObject TopRightLimitgameobject;
    public GameObject BottomLeftLimitgameobject;

    private Vector3 TopRightLimit;
    private Vector3 BottomLeftLimit;

    private Vector2 input;

    // Start is called before the first frame update
    void Start()
    {
        TopRightLimit = TopRightLimitgameobject.transform.position;
        BottomLeftLimit = BottomLeftLimitgameobject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        transform.position += new Vector3(Speed * input.x, Speed * input.y, 0);
        
        if ((transform.position.x <= BottomLeftLimit.x/*&& input.x == -1 */) || (transform.position.x >= TopRightLimit.x /*&& input.x == 1*/))
        {
        input.x = 0;
        }

        if ((transform.position.y <= BottomLeftLimit.y/* && input.x == -1*/) || (transform.position.y >= TopRightLimit.y/* && input.y == 1*/))
        {
        input.y = 0;
        }
        
        transform.position += new Vector3(Speed * input.x, Speed * input.y, 0);
    }
}

//    public float Speed;

//    public GameObject TopRightLimitGameobject;
//    public GameObject BottomLeftLimitGameobject;

//    private Vector3 TopRightLimit;
//    private Vector3 BottomLeftLimit;

//    private Vector2 input;

//    // Start is called before the first frame update
//    void Start()
//    {
//        TopRightLimit = TopRightLimitGameobject.transform.position;
//        BottomLeftLimit = BottomLeftLimitGameobject.transform.position;
//    }

//    // Update is called once per frame
//    void Update()
//    {

//        Speed = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

//        if ((transform.position.x <= BottomLeftLimit.x/*&& input.x == -1 */) || (transform.position.x >= TopRightLimit.x /*&& input.x == 1*/))
//        {
//            //input.x = 0;
//            Speed.x = 0;
//        }

//        if ((transform.position.y <= BottomLeftLimit.y/* && input.x == -1*/) || (transform.position.y >= TopRightLimit.y/* && input.y == 1*/))
//        {
//            //input.y = 0;
//            Speed.y = 0;
//        }

//        transform.position += new Vector3(Speed * input.x, Speed * input.y, 0);
//    }