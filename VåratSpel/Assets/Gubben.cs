using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gubben : MonoBehaviour
{
    //Hur högt man ska hoppa och hastigheten
    [SerializeField, Range(1, 10)]
    public float speed;
    public float Jumb;

    //Variablet för att player ska gå fram
    public Vector3 userDirection = Vector3.right;
    public static int movespeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Koden för objektet att gå runt t.ex fram, tillbaka, höger och vänster + rotation
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        }
        // Hopp knappen för upp och ner
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, Jumb, 0) * Time.deltaTime;
        }

        //Player går fram konstant 
        transform.Translate(userDirection * movespeed * Time.deltaTime);
    }
}
