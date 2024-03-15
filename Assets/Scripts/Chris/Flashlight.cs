using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light _light;

    
    void Start()
    {
        _light = GetComponentInChildren<Light>();
    }

    //Turns light on
    public void LightOn()
    {
        _light.enabled = true;
    }

    //Turns light off
    public void LighOff()
    {
        _light.enabled = false;
        
    }

}
