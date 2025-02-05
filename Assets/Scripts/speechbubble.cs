using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speechbubble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector2 pos;
    Vector2 barrelPos = new Vector2(7.38f, 0.01f);
    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (pos.x >= barrelPos.x - 3 && pos.x <= barrelPos.x + 3 && pos.y >= barrelPos.y - 4 && pos.y <= barrelPos.y + 4)
        {
            transform.localScale = Vector3.one;
            
        } else
        {
            transform.localScale = Vector3.zero;
            
        }
    }
}
