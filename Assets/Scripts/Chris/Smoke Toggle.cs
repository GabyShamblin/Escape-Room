using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines 2 method calls that toggle smoke game object for use with Unity's event system
/// </summary>
public class SmokeToggle : MonoBehaviour
{
    [SerializeField]protected GameObject smoke;


/// <summary>
/// Checks to see if the smoke effect is active, if not then turn it on
/// </summary>
    public void SmokeOn()
    {
        if(smoke.activeSelf != true)
        {
            smoke.SetActive(true);
        }
        
    }

/// <summary>
/// Checks to see if the smoke effect is active, if so then turn it off
/// </summary>
    public void SmokeOff()
    {
        if(smoke.activeSelf == true)
        {
            smoke.SetActive(false);
        }
    }
}
