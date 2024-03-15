using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Creates functionality for turning the flashlight on and off using Unity's Event system and the XR Grab Interactable Component
/// </summary>
public class Lantern : MonoBehaviour
{
    private Light _light;

    //Finds light component
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
    public void LightOff()
    {
        _light.enabled = false;
        
    }

}
