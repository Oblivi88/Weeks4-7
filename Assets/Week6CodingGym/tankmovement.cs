using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class tankmovement : MonoBehaviour
{
    public Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = pos;
        
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

