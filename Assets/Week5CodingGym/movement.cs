using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class movement : MonoBehaviour
{
    Vector2 pos = new Vector2(-8.18999958f, -3.72000003f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos;
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += 0.005f;
        } if (Input.GetKey(KeyCode.S))
        {
            pos.y -= 0.005f;
        }
     if (Input.GetKey(KeyCode.A))
        {
            pos.x -= 0.005f;
        }
     if (Input.GetKey(KeyCode.D))
        {
            pos.x += 0.005f;
        }
        
    }
}