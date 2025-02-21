using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoopSpawner : MonoBehaviour
{
    public GameObject chocolateScoop;
    public GameObject vanillaScoop;
    public GameObject strawberryScoop;
    GameObject chocScoop;
    GameObject vanilScoop;
    GameObject strawScoop;

    public int scoopNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnScoop(int flavour)
    {
        if (flavour == 1)
        {
            Destroy(vanilScoop);
            Destroy(strawScoop);
            Destroy(chocScoop);
            chocScoop = Instantiate(chocolateScoop);
        }
        if (flavour == 2)
        {
            Destroy(strawScoop);
            Destroy(chocScoop);
            Destroy(vanilScoop);
            vanilScoop = Instantiate(vanillaScoop);
        }
        if (flavour == 3)
        {
            Destroy(chocScoop);
            Destroy(vanilScoop);
            Destroy(strawScoop); 
            strawScoop = Instantiate(strawberryScoop);
        }
    }
}
