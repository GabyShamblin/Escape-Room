using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Defines methods for 
/// </summary>
public class Lantern : MonoBehaviour
{
    public GameObject lightSource;
    protected Light _light;

    /// <summary>
    /// Sets light component
    /// </summary>
    void Start()
    {
        _light = lightSource.GetComponent<Light>();
    }

    /// <summary>
    /// Turns light on, returns light source to original position
    /// </summary>
    public void LightOn()
    {
        _light.enabled = true;
        lightSource.transform.position= new Vector3(0f, -0.322f, 0f);
    }

    /// <summary>
    /// Turns light off, sends light source away (was having a bug where light would reveal disappearing material even if not turned on)
    /// </summary>
    public void LightOff()
    {
        _light.enabled = false;
        lightSource.transform.position = new Vector3(0f, 1000f, 0f);
        
    }

}
