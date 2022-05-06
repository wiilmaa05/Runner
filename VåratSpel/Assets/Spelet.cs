using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spelet : MonoBehaviour
{
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
        //Pannan går fram konstant 
        transform.Translate(userDirection * movespeed * Time.deltaTime);
    }
}
