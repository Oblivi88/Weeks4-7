using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoopSpawner : MonoBehaviour
{

    // public gameobjects to reference in inspector
    public GameObject chocolateScoop;
    public GameObject vanillaScoop;
    public GameObject strawberryScoop;
    // will be the spawned objects
    GameObject chocScoop;
    GameObject vanilScoop;
    GameObject strawScoop;

    // determines which button is pushed
    public int scoopNum = 0;
    // reference to the slider in the inspector
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // constantly sets the scale of each spawned scoop to the slider value. But only if they are not null to prevent null ref error 
        if (strawScoop != null)
        {
            strawScoop.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
        }
        if (chocScoop != null)
        {
            chocScoop.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
        }
        if (vanillaScoop != null)
        {
            vanilScoop.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
        }
    }

    public void spawnScoop(int flavour) // takes an argument determined by the button pushed
    {
        // for all, if button is pushed, destroy all other instances of a scoop prefab, spawn a new one.
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

    public void destroyAll()
    {
        Destroy(chocScoop);
        Destroy(vanilScoop);
        Destroy(strawScoop);
        slider.value = slider.minValue;
    }
}
