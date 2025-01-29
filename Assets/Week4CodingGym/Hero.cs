using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 1;
    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            position.y += speed;
            Debug.Log("W");
        }
    }

}
