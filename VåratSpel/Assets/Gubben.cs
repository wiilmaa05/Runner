using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gubben : MonoBehaviour
{
    [SerializeField, Range(1, 10)]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            transform.position += new Vector3(0, speed, 0);
        }
    }
}
