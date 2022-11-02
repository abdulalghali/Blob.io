using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    public List<Material> Mater = new List<Material>(); //allows access to colour materials in unity

    void Awake() //called once when player is created
    {
        GetComponent<Renderer>().material = Mater[Random.Range(0, Mater.Count)];
    }
}
