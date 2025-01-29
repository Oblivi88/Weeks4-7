using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    int health = 100;
    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x >= position.x - 1.5 && mousePos.x <= position.x + 1.5 && mousePos.y >= position.y - 1.5 && mousePos.y <= position.y + 1.5)
            {
                health--;
            }
        }
    }
}
