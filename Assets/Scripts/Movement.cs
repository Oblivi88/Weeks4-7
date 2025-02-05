using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector2 pos;
    // Update is called once per frame
    void Update()
    {
        
        transform.position = pos;
        if (Input.GetKey(KeyCode.W)) 
        {
            pos.y += 0.005f;
        } 
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= 0.005f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= 0.005f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += 0.005f;
        }

      
    }
}
