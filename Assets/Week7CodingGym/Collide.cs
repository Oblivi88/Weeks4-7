using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Vector2 playerPosition;
    public Vector2 pos;
    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (playerPosition.x >= pos.x - 0.5 && playerPosition.x <= pos.x + 0.5 && playerPosition.y >= pos.y - 0.5 && playerPosition.y <= pos.y + 0.5)
        {
            player
        }
    }
}
