using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // declare the slider
    public Slider slider;
    // this will serve as the timer value
    public float t;
    // whether or not the timer is currently active or not
    public bool isCounting = false;
    
    // Start is called before the first frame update
    void Start()
    {
        // get the slider component from this object
        slider = GetComponent<Slider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting) // if the timer is active, increase t slowly and set the slider value to it
        {
            t += Time.deltaTime / 15;
            slider.value = t;
            
        }
        
    }

    // when called will start the timer
    public void startTimer()
    {
        isCounting = true;
    }
    // when called will stop and reset the timer. Both of these functions are called by buttons
    public void resetTimer()
    {
        isCounting = false;
        slider.value = 0;
        t = 0;
    }
}
