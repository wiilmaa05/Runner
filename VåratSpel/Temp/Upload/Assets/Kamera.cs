using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    //Kammera variabeln
    public Transform target;

    //Hur positionen av kameran ska vara i x,y,z t.ex hur nära den ska vara 
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //För att kameran ska följa med objectet 
        transform.position = target.position + offset;
    }
}
