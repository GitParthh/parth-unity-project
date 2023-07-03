using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grim : MonoBehaviour
{
    public Rigidbody2D Grimbody;
    public float flapStrenth;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }


     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Grimbody.velocity = Vector2.up * flapStrenth;
           
        }
    }

    
}
