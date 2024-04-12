using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Creates functionality for turning the flashlight on and off using Unity's Event system and the XR Grab Interactable Component
/// </summary>
public class Lantern : MonoBehaviour
{
    public GameObject _light;
    private Light light;

    //Finds light component
    void Start()
    {
        light = _light.GetComponent<Light>();
    }

    //Turns light on
    public void LightOn()
    {
        light.enabled = true;
        _light.transform.position= new Vector3(0f, -0.322f, 0f);
    }

    //Turns light off
    public void LightOff()
    {
        light.enabled = false;
        _light.transform.position = new Vector3(0f, 1000f, 0f);
        
    }

}
