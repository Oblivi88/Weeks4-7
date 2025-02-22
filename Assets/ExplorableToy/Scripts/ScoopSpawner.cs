using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ScoopSpawner : MonoBehaviour
{

    // public gameobjects to reference in inspector
    public GameObject chocolateScoop;
    public GameObject vanillaScoop;
    public GameObject strawberryScoop;
    public GameObject chocolateDrip;
    public GameObject vanillaDrip;
    public GameObject strawberryDrip;
    // will be the spawned objects
    GameObject chocScoop;
    GameObject vanilScoop;
    GameObject strawScoop;
    GameObject chocDrip;
    GameObject vanilDrip;
    GameObject strawDrip;

    // determines which button is pushed
    public int scoopNum = 0;
    // reference to the slider in the inspector
    public Slider slider;
    // reference to the timer object in the inspector (will be used for getComponent)
    public GameObject timer;
    // determines which flavour the player had, to spawn the proper drip sprite
    int dripFlavour;
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
        if (vanilScoop != null)
        {
            vanilScoop.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
        }

        // if the timer has reached the max,
        if (timer.GetComponent<Timer>().t >= timer.GetComponent<Timer>().slider.maxValue)
        {
            
            // check which flavour is spawned, then set the int variable accordingly
            if (chocScoop != null)
            {
                dripFlavour = 1;
            } else if (vanilScoop != null)
            {
                dripFlavour = 2;
            } else if (strawScoop != null)
            {
                dripFlavour = 3;
            }
            // immediately after that, destroy every sprite present, then quickly spawn a new drip sprite
            destroyAll();
            spawnDrip();
        }
        // if the timer is not at the max, do not show a drip
        if (timer.GetComponent<Timer>().t < timer.GetComponent<Timer>().slider.maxValue)
        {
            Destroy(chocDrip);
            Destroy(vanilDrip);
            Destroy(strawDrip); 
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
    // destroys all current sprites on screen and resets the slider value
    public void destroyAll()
    {
        Destroy(chocScoop);
        Destroy(vanilScoop);
        Destroy(strawScoop);
        Destroy(chocDrip);
        Destroy(vanilDrip);
        Destroy(strawDrip);
        slider.value = slider.minValue;
    }
    // spawns the drip flavour when the timer reaches max
    public void spawnDrip()
    {
        // this variable is set above
        if (dripFlavour == 1)
        {
            chocDrip = Instantiate(chocolateDrip);
        }
        else if (dripFlavour == 2)
        {
            vanilDrip = Instantiate(vanillaDrip);
        }
        else if (dripFlavour == 3)
        {
            strawDrip = Instantiate(strawberryDrip);
        }

    }
}
