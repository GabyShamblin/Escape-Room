using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

/// <summary>
/// Defines methods for 
/// </summary>
public class Lantern : MonoBehaviour
{
    public GameObject _lantern;
    public GameObject _spotlight;

    

    /// <summary>
    /// Turns light on, returns light source to original position
    /// </summary>
    public void LightOn()
    {
        _spotlight.transform.position = new Vector3(0f, -0.3f, 0f);
        _spotlight.SetActive(true);
    }

    /// <summary>
    /// Turns light off, sends light source away (was having a bug where light would reveal disappearing material even if not turned on)
    /// </summary>
    public void LightOff()
    {
        _spotlight.SetActive(false);
        _spotlight.transform.position = new Vector3(0f, 1000f, 0f);
        
    }

}
